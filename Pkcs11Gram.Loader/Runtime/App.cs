// Project: Pkcs11Gram.Loader
// File: App.cs
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
using Castle.Core.Logging;
using Castle.MicroKernel;
using Pkcs11Gram.Core;
using Pkcs11Gram.Core.Exception;
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Runtime;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Pkcs11Gram.Loader.Runtime
{
    internal sealed class App : AppBase, IApp
    {
        internal IKernel Kernel { get; private set; }
        private ILogger m_logger;

        public App(IKernel kernel)
            : base(kernel)
        {
            Kernel = kernel;
            SartupTime = DateTime.Now;
        }

        /// <summary>
        /// Libarary Base Directory
        /// </summary>
        public string BaseDirectory { get; internal set; }

        /// <summary>
        /// Libaray Startup time
        /// </summary>
        public DateTime SartupTime { get; private set; }

        /// <summary>
        /// Logger
        /// </summary>
        public ILogger Logger
        {
            get
            {
                if (m_logger == null)
                    m_logger = Kernel.Resolve<ILoggerFactory>().Create(typeof(IApp));

                return m_logger;
            }
        }

        /// <summary>
        /// Is Initialized
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Pkcs11 Function List
        /// </summary>
        public FunctionList FunctionList { get; internal set; }

        /// <summary>
        /// Library Version
        /// </summary>
        public ILibraryVersion LibraryVersion { get; } = new LibraryVersion();

        /// <summary>
        /// All Slots
        /// </summary>
        public IDictionary<uint, ISlot> Slots { get; private set; } = new Dictionary<uint, ISlot>();

        /// <summary>
        /// All Opened Session
        /// </summary>
        public IDictionary<uint, ISession> Sessions { get; private set; } = new Dictionary<uint, ISession>();

        /// <summary>
        /// Finalize Library
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Finalize()
        {
            Slots.Clear();
            IsInitialized = false;
            await Task.Yield();
            return true;
        }

        /// <summary>
        /// Initialize Library
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Initialize()
        {
            var providers = Kernel.ResolveAll<IProvider>();

            foreach (var item in providers)
            {
                var slots = await item.GetSlots();
                foreach (var slot in slots)
                {
                    UInt32 id = Convert.ToUInt32(Slots.Count);
                    slot.SlotId = id;
                    Slots.Add(id, slot);
                }
            }

            IsInitialized = true;
            return true;
        }
    }
}
