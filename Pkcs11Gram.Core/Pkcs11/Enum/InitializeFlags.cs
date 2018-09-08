// Project: Pkcs11Gram.Core
// File: InitializeFlags.cs
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

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_INITIALIZE_FLAGS
    /// </summary>
    [Flags]
    public enum InitializeFlags : UInt32
    {
        /// <summary>
        /// True if application threads which are executing calls to the library may not use native operating system 
        /// calls to spawn new threads; false if they may
        /// </summary>
        LIBRARY_CANT_CREATE_OS_THREADS = 0x00000001,

        /// <summary>
        /// True if the library can use the native operation system threading model for locking; false otherwise
        /// </summary>
        OS_LOCKING_OK = 0x00000002,
    }
}
