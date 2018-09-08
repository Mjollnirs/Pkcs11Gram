// Project: Pkcs11Gram.Core
// File: KeyType.cs
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
    /// CK_KEY_TYPE
    /// Key types
    /// </summary>
    public enum KeyType : UInt32
    {
        /// <summary>
        /// RSA key
        /// </summary>
        RSA = 0x00000000,

        /// <summary>
        /// DSA key
        /// </summary>
        DSA = 0x00000001,

        /// <summary>
        /// DH (Diffie-Hellman) key
        /// </summary>
        DH = 0x00000002,

        /// <summary>
        /// EC (Elliptic Curve) key
        /// </summary>
        ECDSA = 0x00000003,

        /// <summary>
        /// EC (Elliptic Curve) key
        /// </summary>
        EC = 0x00000003,

        /// <summary>
        /// X9.42 Diffie-Hellman public keys
        /// </summary>
        X9_42_DH = 0x00000004,

        /// <summary>
        /// KEA keys
        /// </summary>
        KEA = 0x00000005,

        /// <summary>
        /// Generic secret key
        /// </summary>
        GENERIC_SECRET = 0x00000010,

        /// <summary>
        /// RC2 key
        /// </summary>
        RC2 = 0x00000011,

        /// <summary>
        /// RC4 key
        /// </summary>
        RC4 = 0x00000012,

        /// <summary>
        /// Single-length DES key
        /// </summary>
        DES = 0x00000013,

        /// <summary>
        /// Double-length DES key
        /// </summary>
        DES2 = 0x00000014,

        /// <summary>
        /// Triple-length DES key
        /// </summary>
        DES3 = 0x00000015,

        /// <summary>
        /// CAST key
        /// </summary>
        CAST = 0x00000016,

        /// <summary>
        /// CAST3 key
        /// </summary>
        CAST3 = 0x00000017,

        /// <summary>
        /// CAST128 key
        /// </summary>
        CAST5 = 0x00000018,

        /// <summary>
        /// CAST128 key
        /// </summary>
        CAST128 = 0x00000018,

        /// <summary>
        /// RC5 key
        /// </summary>
        RC5 = 0x00000019,

        /// <summary>
        /// IDEA key
        /// </summary>
        IDEA = 0x0000001A,

        /// <summary>
        /// Single-length MEK or a TEK
        /// </summary>
        SKIPJACK = 0x0000001B,

        /// <summary>
        /// Single-length BATON key
        /// </summary>
        BATON = 0x0000001C,

        /// <summary>
        /// Single-length JUNIPER key
        /// </summary>
        JUNIPER = 0x0000001D,

        /// <summary>
        /// Single-length CDMF key
        /// </summary>
        CDMF = 0x0000001E,

        /// <summary>
        /// AES key
        /// </summary>
        AES = 0x0000001F,

        /// <summary>
        /// Blowfish key
        /// </summary>
        BLOWFISH = 0x00000020,

        /// <summary>
        /// Twofish key
        /// </summary>
        TWOFISH = 0x00000021,

        /// <summary>
        /// RSA SecurID secret key
        /// </summary>
        SECURID = 0x00000022,

        /// <summary>
        /// Generic secret key and associated counter value
        /// </summary>
        HOTP = 0x00000023,

        /// <summary>
        /// ActivIdentity ACTI secret key
        /// </summary>
        ACTI = 0x00000024,

        /// <summary>
        /// Camellia key
        /// </summary>
        CAMELLIA = 0x00000025,

        /// <summary>
        /// ARIA key
        /// </summary>
        ARIA = 0x00000026,

        /// <summary>
        /// MD5 HMAC key
        /// </summary>
        MD5_HMAC = 0x00000027,

        /// <summary>
        /// SHA-1 HMAC key
        /// </summary>
        SHA_1_HMAC = 0x00000028,

        /// <summary>
        /// RIPE-MD 128 HMAC key
        /// </summary>
        RIPEMD128_HMAC = 0x00000029,

        /// <summary>
        /// RIPE-MD 160 HMAC key
        /// </summary>
        RIPEMD160_HMAC = 0x0000002A,

        /// <summary>
        /// SHA-256 HMAC key
        /// </summary>
        SHA256_HMAC = 0x0000002B,

        /// <summary>
        /// SHA-384 HMAC key
        /// </summary>
        SHA384_HMAC = 0x0000002C,

        /// <summary>
        /// SHA-512 HMAC key
        /// </summary>
        SHA512_HMAC = 0x0000002D,

        /// <summary>
        /// SHA-224 HMAC key
        /// </summary>
        SHA224_HMAC = 0x0000002E,

        /// <summary>
        /// SEED secret key
        /// </summary>
        SEED = 0x0000002F,

        /// <summary>
        /// GOST R 34.10-2001 key
        /// </summary>
        GOSTR3410 = 0x00000030,

        /// <summary>
        /// GOST R 34.11-94 key or domain parameter
        /// </summary>
        GOSTR3411 = 0x00000031,

        /// <summary>
        /// GOST 28147-89 key or domain parameter
        /// </summary>
        GOST28147 = 0x00000032,

        /// <summary>
        /// Permanently reserved for token vendors
        /// </summary>
        VENDOR_DEFINED = 0x80000000
    }
}
