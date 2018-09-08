// Project: Pkcs11Gram.Core
// File: ProviderBase.cs
// 
// Copyright 2018 Mjollnir<mjollnir@59k.org>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel;
using Pkcs11Gram.Core.Slot;

namespace Pkcs11Gram.Core
{
    public abstract class ProviderBase<TSlot, TToken> : IProvider
        where TSlot: class, ISlot
        where TToken: class, IToken
    {
        private readonly IKernel kernel;

        public ProviderBase(IKernel _kernel)
        {
            kernel = _kernel;
        }

        private IList<ISlot> Slots { get; set; } = new List<ISlot>();

        public async Task<IList<ISlot>> GetSlots()
        {
            await ProcessSlots();
            return Slots;
        }

        protected abstract Task ProcessSlots();

        protected async Task<TSlot> AddSlotAsync()
        {
            TSlot slot = kernel.Resolve<TSlot>();
            Slots.Add(slot);
            await Task.Yield();
            return slot;
        }

        protected async Task RemoveSlotAsync(TSlot slot)
        {
            Slots.Remove(slot);
            await Task.Yield();
        }

        public async Task<IToken> GetToken(ISlot slot)
        {
            return await slot.GetToken();
        }
    }
}
