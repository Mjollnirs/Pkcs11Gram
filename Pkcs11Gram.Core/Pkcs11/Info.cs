// Project: Pkcs11Gram.Core
// File: Info.cs
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
    /// CK_INFO
    /// Provides general information about Cryptoki
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct Info
    {
        /// <summary>
        /// Cryptoki interface version number, for compatibility with future revisions of this interface.
        /// </summary>
        public Pkcs11Version CryptokiVersion;

        /// <summary>
        /// ID of the Cryptoki library manufacturer. Must be padded with the blank character (‘ ‘). Should not be null-terminated.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] ManufacturerId;

        /// <summary>
        /// Bit flags reserved for future versions. Must be zero for this version
        /// </summary>
        public UInt32 Flags;

        /// <summary>
        /// Character-string description of the library. Must be padded with the blank character (‘ ‘). Should not be null-terminated.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] LibraryDescription;

        /// <summary>
        /// Cryptoki library version number
        /// </summary>
        public Pkcs11Version LibraryVersion;
    }
}
