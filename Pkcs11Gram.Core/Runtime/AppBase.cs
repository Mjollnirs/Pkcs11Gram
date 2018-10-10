// Project: Pkcs11Gram.Core
// File: AppBase.cs
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
using Castle.MicroKernel;
using Pkcs11Gram.Core.Exception;
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Runtime
{
    public abstract class AppBase
    {
        internal static IKernel Container { get; private set; }

        public AppBase(IKernel windsorContainer)
        {
            Container = windsorContainer;
        }

        protected Dictionary<UInt32, ISlot> _slot = new Dictionary<uint, ISlot>();
        protected Dictionary<UInt32, ISession> _session = new Dictionary<uint, ISession>();

        /// <summary>
        /// All Slots
        /// </summary>
        public IReadOnlyDictionary<UInt32, ISlot> Slots { get { return _slot; } }

        /// <summary>
        /// All Sessions
        /// </summary>
        public IReadOnlyDictionary<UInt32, ISession> Sessions { get { return _session; } }

        internal UInt32 AddSession(ISession session)
        {
            UInt32 id = (UInt32)Sessions.Count + 1;
            _session.Add(id, session);
            return id;
        }
    }
}
