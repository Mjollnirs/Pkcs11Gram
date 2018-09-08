// Project: Pkcs11Gram.Core
// File: MechanismFlags.cs
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
    /// CK_MECHANISM_FLAGS
    /// </summary>
    [Flags]
    public enum MechanismFlags : UInt32
    {
        /// <summary>
        /// True if the mechanism is performed by the device, false if the mechanism is performed in software
        /// </summary>
        HW = 0x00000001,

        /// <summary>
        /// True if the mechanism can be used with C_EncryptInit
        /// </summary>
        ENCRYPT = 0x00000100,

        /// <summary>
        /// True if the mechanism can be used with C_DecryptInit
        /// </summary>
        DECRYPT = 0x00000200,

        /// <summary>
        /// True if the mechanism can be used with C_DigestInit
        /// </summary>
        DIGEST = 0x00000400,

        /// <summary>
        /// True if the mechanism can be used with C_SignInit
        /// </summary>
        SIGN = 0x00000800,

        /// <summary>
        /// True if the mechanism can be used with C_SignRecoverInit
        /// </summary>
        SIGN_RECOVER = 0x00001000,

        /// <summary>
        /// True if the mechanism can be used with C_VerifyInit
        /// </summary>
        VERIFY = 0x00002000,

        /// <summary>
        /// True if the mechanism can be used with C_VerifyRecoverInit
        /// </summary>
        VERIFY_RECOVER = 0x00004000,

        /// <summary>
        /// True if the mechanism can be used with C_GenerateKey
        /// </summary>
        GENERATE = 0x00008000,

        /// <summary>
        /// True if the mechanism can be used with C_GenerateKeyPair
        /// </summary>
        GENERATE_KEY_PAIR = 0x00010000,

        /// <summary>
        /// True if the mechanism can be used with C_WrapKey
        /// </summary>
        WRAP = 0x00020000,

        /// <summary>
        /// True if the mechanism can be used with C_UnwrapKey
        /// </summary>
        UNWRAP = 0x00040000,

        /// <summary>
        /// True if the mechanism can be used with C_DeriveKey
        /// </summary>
        DERIVE = 0x00080000,

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters over Fp
        /// </summary>
        EC_F_P = 0x00100000,

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters over F2m
        /// </summary>
        EC_F_2M = 0x00200000,

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters of the choice ecParameters
        /// </summary>
        EC_ECPARAMETERS = 0x00400000,

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters of the choice namedCurve
        /// </summary>
        EC_NAMEDCURVE = 0x00800000,

        /// <summary>
        /// True if the mechanism can be used with elliptic curve point uncompressed
        /// </summary>
        EC_UNCOMPRESS = 0x01000000,

        /// <summary>
        /// True if the mechanism can be used with elliptic curve point compressed
        /// </summary>
        EC_COMPRESS = 0x02000000,

        /// <summary>
        /// True if there is an extension to the flags, false if no extensions
        /// </summary>
        EXTENSION = 0x80000000,
    }
}
