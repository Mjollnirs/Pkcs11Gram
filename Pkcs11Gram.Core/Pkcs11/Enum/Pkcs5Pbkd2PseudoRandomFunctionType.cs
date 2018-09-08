// Project: Pkcs11Gram.Core
// File: Pkcs5Pbkd2PseudoRandomFunctionType.cs
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
    /// CK_PKCS5_PBKD2_PSEUDO_RANDOM_FUNCTION_TYPE
    /// Pseudo-random functions
    /// </summary>
    public enum Pkcs5Pbkd2PseudoRandomFunctionType : UInt32
    {
        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-1 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA1 = 0x00000001,

        /// <summary>
        /// PKCS#5 PBKDF2 with GOST R34.11-94 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_GOSTR3411 = 0x00000002,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-224 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA224 = 0x00000003,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-256 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA256 = 0x00000004,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-384 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA384 = 0x00000005,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-512 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA512 = 0x00000006,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-512/224 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA512_224 = 0x00000007,

        /// <summary>
        /// PKCS#5 PBKDF2 with HMAC-SHA-512/256 pseudorandom function
        /// </summary>
        PKCS5_PBKD2_HMAC_SHA512_256 = 0x00000008
    }
}
