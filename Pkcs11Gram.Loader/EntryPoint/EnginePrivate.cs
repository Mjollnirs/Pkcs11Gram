// Project: Pkcs11Gram.Loader
// File: EnginePrivate.cs
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
using Pkcs11Gram.Core.Exception;
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.Loader.EntryPoint
{
    internal partial class Engine
    {
        private ISlot GetSlot(UInt32 slotID)
        {
            if (!App.Slots.ContainsKey(slotID))
                throw new Pkcs11Exception("Get slot faild!", Rv.SLOT_ID_INVALID);

            return App.Slots[slotID];
        }

        private IToken GetToken(UInt32 slotID)
        {
            ISlot slot = GetSlot(slotID);

            if (!slot.HasToken)
                throw new Pkcs11Exception("Get token faild!", Rv.DEVICE_REMOVED);

            Task<IToken> task = slot.GetToken();
            if (task.Exception != null)
                throw new Pkcs11Exception("Get token faild!", Rv.DEVICE_ERROR);

            return task.Result;
        }
    }
}
