// Project: Pkcs11Gram.Core
// File: RasPkcsMgfType.cs
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
    /// CK_RSA_PKCS_MGF_TYPE
    /// Mask generation functions
    /// </summary>
    public enum RasPkcsMgfType : UInt32
    {
        /// <summary>
        /// PKCS #1 Mask Generation Function with SHA-1 digest algorithm
        /// </summary>
        CKG_MGF1_SHA1 = 0x00000001,

        /// <summary>
        /// PKCS #1 Mask Generation Function with SHA-256 digest algorithm
        /// </summary>
        CKG_MGF1_SHA256 = 0x00000002,

        /// <summary>
        /// PKCS #1 Mask Generation Function with SHA-384 digest algorithm
        /// </summary>
        CKG_MGF1_SHA384 = 0x00000003,

        /// <summary>
        /// PKCS #1 Mask Generation Function with SHA-512 digest algorithm
        /// </summary>
        CKG_MGF1_SHA512 = 0x00000004,

        /// <summary>
        /// PKCS #1 Mask Generation Function with SHA-224 digest algorithm
        /// </summary>
        CKG_MGF1_SHA224 = 0x00000005
    }
}
