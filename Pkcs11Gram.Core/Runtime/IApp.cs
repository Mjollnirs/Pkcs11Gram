// Project: Pkcs11Gram.Core
// File: IApp.cs
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
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Runtime
{
    public interface IApp
    {
        /// <summary>
        /// Libarary Base Directory
        /// </summary>
        string BaseDirectory { get; }

        /// <summary>
        /// Libaray Startup time
        /// </summary>
        DateTime SartupTime { get; }

        /// <summary>
        /// Logger
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// Is Initialized
        /// </summary>
        bool IsInitialized { get; }

        /// <summary>
        /// Library Version
        /// </summary>
        ILibraryVersion LibraryVersion { get; }

        /// <summary>
        /// Castle Kernel
        /// </summary>
        IKernel Kernel { get; }
    }
}