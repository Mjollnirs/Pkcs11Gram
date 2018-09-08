﻿// Project: Pkcs11Gram.Core
// File: SessionInfo.cs
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

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_SESSION_INFO
    /// Information about a session
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct SessionInfo
    {
        /// <summary>
        /// ID of the slot that interfaces with the token
        /// </summary>
        public UInt32 SlotId;

        /// <summary>
        /// The state of the session
        /// </summary>
        public State State;

        /// <summary>
        /// Bit flags that define the type of session
        /// </summary>
        public SessionFlags Flags;

        /// <summary>
        /// An error code defined by the cryptographic device. Used for errors not covered by Cryptoki.
        /// </summary>
        public UInt32 DeviceError;
    }
}
