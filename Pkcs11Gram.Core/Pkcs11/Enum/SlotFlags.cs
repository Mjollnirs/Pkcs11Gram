// Project: Pkcs11Gram.Core
// File: SlotFlags.cs
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

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_SLOT_FLAGS
    /// flags: bit flags that provide capabilities of the slot
    /// </summary>
    [Flags]
    public enum SlotFlags : UInt32
    {
        /// <summary>
        /// Default value
        /// </summary>
        NONE = 0x00000000,

        /// <summary>
        /// True if a token is present in the slot
        /// </summary>
        TOKEN_PRESENT = 0x00000001,

        /// <summary>
        /// True if the reader supports removable devices
        /// </summary>
        REMOVABLE_DEVICE = 0x00000002,

        /// <summary>
        /// True if the slot is a hardware slot, as opposed to a software slot implementing a "soft token"
        /// </summary>
        HW_SLOT = 0x00000004,
    }
}
