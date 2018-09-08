// Project: Pkcs11Gram.Core
// File: MechanismType.cs
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
    /// CK_MECHANISM_TYPE
    /// Mechanism type
    /// </summary>
    public enum MechanismType : UInt32
    {
        /// <summary>
        /// Key pair generation mechanism based on the RSA public-key cryptosystem, as defined in PKCS #1
        /// </summary>
        RSA_PKCS_KEY_PAIR_GEN = 0x00000000,

        /// <summary>
        /// Multi-purpose mechanism based on the RSA public-key cryptosystem and the block formats initially defined in PKCS #1 v1.5.
        /// </summary>
        RSA_PKCS = 0x00000001,

        /// <summary>
        /// Mechanism for single-part signatures and verification with and without message recovery based on the RSA public-key cryptosystem and the block formats defined in ISO/IEC 9796 and its annex A
        /// </summary>
        RSA_9796 = 0x00000002,

        /// <summary>
        /// Multi-purpose mechanism based on the RSA public-key cryptosystem ("raw" RSA, as assumed in X.509)
        /// </summary>
        RSA_X_509 = 0x00000003,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with MD2 mechanism
        /// </summary>
        MD2_RSA_PKCS = 0x00000004,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with MD5 mechanism
        /// </summary>
        MD5_RSA_PKCS = 0x00000005,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with SHA-1 mechanism
        /// </summary>
        SHA1_RSA_PKCS = 0x00000006,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with RIPEMD-128
        /// </summary>
        RIPEMD128_RSA_PKCS = 0x00000007,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with RIPEMD-160
        /// </summary>
        RIPEMD160_RSA_PKCS = 0x00000008,

        /// <summary>
        /// The PKCS #1 RSA OAEP mechanism based on the RSA public-key cryptosystem and the OAEP block format defined in PKCS #1
        /// </summary>
        RSA_PKCS_OAEP = 0x00000009,

        /// <summary>
        /// The X9.31 RSA key pair generation mechanism
        /// </summary>
        RSA_X9_31_KEY_PAIR_GEN = 0x0000000A,

        /// <summary>
        /// The ANSI X9.31 RSA mechanism
        /// </summary>
        RSA_X9_31 = 0x0000000B,

        /// <summary>
        /// The ANSI X9.31 RSA signature with SHA-1 mechanism
        /// </summary>
        SHA1_RSA_X9_31 = 0x0000000C,

        /// <summary>
        /// The PKCS #1 RSA PSS mechanism based on the RSA public-key cryptosystem and the PSS block format defined in PKCS#1
        /// </summary>
        RSA_PKCS_PSS = 0x0000000D,

        /// <summary>
        /// The PKCS #1 RSA PSS signature with SHA-1 mechanism
        /// </summary>
        SHA1_RSA_PKCS_PSS = 0x0000000E,

        /// <summary>
        /// The DSA key pair generation mechanism
        /// </summary>
        DSA_KEY_PAIR_GEN = 0x00000010,

        /// <summary>
        /// The DSA without hashing mechanism
        /// </summary>
        DSA = 0x00000011,

        /// <summary>
        /// The DSA with SHA-1 mechanism
        /// </summary>
        DSA_SHA1 = 0x00000012,

        /// <summary>
        /// The DSA with SHA-224 mechanism
        /// </summary>
        DSA_SHA224 = 0x00000013,

        /// <summary>
        /// The DSA with SHA-256 mechanism
        /// </summary>
        DSA_SHA256 = 0x00000014,

        /// <summary>
        /// The DSA with SHA-384 mechanism
        /// </summary>
        DSA_SHA384 = 0x00000015,

        /// <summary>
        /// The DSA with SHA-512 mechanism
        /// </summary>
        DSA_SHA512 = 0x00000016,

        /// <summary>
        /// The PKCS #3 Diffie-Hellman key pair generation mechanism
        /// </summary>
        DH_PKCS_KEY_PAIR_GEN = 0x00000020,

        /// <summary>
        /// The PKCS #3 Diffie-Hellman key derivation mechanism
        /// </summary>
        DH_PKCS_DERIVE = 0x00000021,

        /// <summary>
        /// The X9.42 Diffie-Hellman key pair generation mechanism
        /// </summary>
        X9_42_DH_KEY_PAIR_GEN = 0x00000030,

        /// <summary>
        /// The X9.42 Diffie-Hellman key derivation mechanism
        /// </summary>
        X9_42_DH_DERIVE = 0x00000031,

        /// <summary>
        /// The X9.42 Diffie-Hellman hybrid key derivation mechanism
        /// </summary>
        X9_42_DH_HYBRID_DERIVE = 0x00000032,

        /// <summary>
        /// The X9.42 Diffie-Hellman Menezes-Qu-Vanstone (MQV) key derivation mechanism
        /// </summary>
        X9_42_MQV_DERIVE = 0x00000033,

        /// <summary>
        /// PKCS #1 v1.5 RSA signature with SHA-256 mechanism
        /// </summary>
        SHA256_RSA_PKCS = 0x00000040,

        /// <summary>
        /// PKCS #1 v1.5 RSA signature with SHA-384 mechanism
        /// </summary>
        SHA384_RSA_PKCS = 0x00000041,

        /// <summary>
        /// PKCS #1 v1.5 RSA signature with SHA-512 mechanism
        /// </summary>
        SHA512_RSA_PKCS = 0x00000042,

        /// <summary>
        /// The PKCS #1 RSA PSS signature with SHA-256 mechanism
        /// </summary>
        SHA256_RSA_PKCS_PSS = 0x00000043,

        /// <summary>
        /// The PKCS #1 RSA PSS signature with SHA-384 mechanism
        /// </summary>
        SHA384_RSA_PKCS_PSS = 0x00000044,

        /// <summary>
        /// The PKCS #1 RSA PSS signature with SHA-512 mechanism
        /// </summary>
        SHA512_RSA_PKCS_PSS = 0x00000045,

        /// <summary>
        /// The PKCS #1 v1.5 RSA signature with SHA-224 mechanism
        /// </summary>
        SHA224_RSA_PKCS = 0x00000046,

        /// <summary>
        /// The PKCS #1 RSA PSS signature with SHA-224 mechanism
        /// </summary>
        SHA224_RSA_PKCS_PSS = 0x00000047,

        /// <summary>
        /// The SHA-512/224 digesting mechanism
        /// </summary>
        SHA512_224 = 0x00000048,

        /// <summary>
        /// Special case of the general-length SHA-512/224-HMAC mechanism
        /// </summary>
        SHA512_224_HMAC = 0x00000049,

        /// <summary>
        /// The general-length SHA-512/224-HMAC mechanism that uses the HMAC construction, based on the SHA-512/224 hash function
        /// </summary>
        SHA512_224_HMAC_GENERAL = 0x0000004A,

        /// <summary>
        /// Key derivation based on the SHA-512/224 hash function
        /// </summary>
        SHA512_224_KEY_DERIVATION = 0x0000004B,

        /// <summary>
        /// The SHA-512/256 digesting mechanism
        /// </summary>
        SHA512_256 = 0x0000004C,

        /// <summary>
        /// Special case of the general-length SHA-512/256-HMAC mechanism
        /// </summary>
        SHA512_256_HMAC = 0x0000004D,

        /// <summary>
        /// The general-length SHA-512/256-HMAC mechanism that uses the HMAC construction, based on the SHA-512/256 hash function
        /// </summary>
        SHA512_256_HMAC_GENERAL = 0x0000004E,

        /// <summary>
        /// Key derivation based on the SHA-512/256 hash function
        /// </summary>
        SHA512_256_KEY_DERIVATION = 0x0000004F,

        /// <summary>
        /// The SHA-512/t digesting mechanism
        /// </summary>
        SHA512_T = 0x00000050,

        /// <summary>
        /// Special case of the general-length SHA-512/t-HMAC mechanism
        /// </summary>
        SHA512_T_HMAC = 0x00000051,

        /// <summary>
        /// The general-length SHA-512/t-HMAC mechanism that uses the HMAC construction, based on the SHA-512/t hash function
        /// </summary>
        SHA512_T_HMAC_GENERAL = 0x00000052,

        /// <summary>
        /// Key derivation based on the SHA-512/t hash function
        /// </summary>
        SHA512_T_KEY_DERIVATION = 0x00000053,

        /// <summary>
        /// The RC2 key generation mechanism
        /// </summary>
        RC2_KEY_GEN = 0x00000100,

        /// <summary>
        /// RC2-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        RC2_ECB = 0x00000101,

        /// <summary>
        /// RC2-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        RC2_CBC = 0x00000102,

        /// <summary>
        /// Special case of general-length RC2-MAC mechanism
        /// </summary>
        RC2_MAC = 0x00000103,

        /// <summary>
        /// General-length RC2-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        RC2_MAC_GENERAL = 0x00000104,

        /// <summary>
        /// RC2-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        RC2_CBC_PAD = 0x00000105,

        /// <summary>
        /// The RC4 key generation mechanism
        /// </summary>
        RC4_KEY_GEN = 0x00000110,

        /// <summary>
        /// RC4 encryption mechanism
        /// </summary>
        RC4 = 0x00000111,

        /// <summary>
        /// Single-length DES key generation mechanism
        /// </summary>
        DES_KEY_GEN = 0x00000120,

        /// <summary>
        /// DES-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        DES_ECB = 0x00000121,

        /// <summary>
        /// DES-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        DES_CBC = 0x00000122,

        /// <summary>
        /// Special case of general-length DES-MAC mechanism
        /// </summary>
        DES_MAC = 0x00000123,

        /// <summary>
        /// General-length DES-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        DES_MAC_GENERAL = 0x00000124,

        /// <summary>
        /// DES-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        DES_CBC_PAD = 0x00000125,

        /// <summary>
        /// Double-length DES key generation mechanism
        /// </summary>
        DES2_KEY_GEN = 0x00000130,

        /// <summary>
        /// Triple-length DES key generation mechanism
        /// </summary>
        DES3_KEY_GEN = 0x00000131,

        /// <summary>
        /// DES3-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        DES3_ECB = 0x00000132,

        /// <summary>
        /// DES3-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        DES3_CBC = 0x00000133,

        /// <summary>
        /// Special case of general-length DES3-MAC mechanism
        /// </summary>
        DES3_MAC = 0x00000134,

        /// <summary>
        /// General-length DES3-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        DES3_MAC_GENERAL = 0x00000135,

        /// <summary>
        /// DES3-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        DES3_CBC_PAD = 0x00000136,

        /// <summary>
        /// General-length DES3-CMAC mechanism based on Cipher-based Message Authenticate Code as defined in NIST SP 800-38B and RFC 4493
        /// </summary>
        DES3_CMAC_GENERAL = 0x00000137,

        /// <summary>
        /// Special case of general-length DES3-CMAC mechanism based on Cipher-based Message Authenticate Code as defined in NIST SP 800-38B and RFC 4493
        /// </summary>
        DES3_CMAC = 0x00000138,

        /// <summary>
        /// Single-length CDMF key generation mechanism
        /// </summary>
        CDMF_KEY_GEN = 0x00000140,

        /// <summary>
        /// CDMF-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CDMF_ECB = 0x00000141,

        /// <summary>
        /// CDMF-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CDMF_CBC = 0x00000142,

        /// <summary>
        /// Special case of general-length CDMF-MAC mechanism
        /// </summary>
        CDMF_MAC = 0x00000143,

        /// <summary>
        /// General-length CDMF-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CDMF_MAC_GENERAL = 0x00000144,

        /// <summary>
        /// CDMF-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CDMF_CBC_PAD = 0x00000145,

        /// <summary>
        /// DES-OFB64 encryption mechanism with output feedback mode (OFB)
        /// </summary>
        DES_OFB64 = 0x00000150,

        /// <summary>
        /// DES-OFB8 encryption mechanism with output feedback mode (OFB)
        /// </summary>
        DES_OFB8 = 0x00000151,

        /// <summary>
        /// DES-CFB64 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        DES_CFB64 = 0x00000152,

        /// <summary>
        /// DES-CFB8 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        DES_CFB8 = 0x00000153,

        /// <summary>
        /// The MD2 digesting mechanism
        /// </summary>
        MD2 = 0x00000200,

        /// <summary>
        /// Special case of the general-length MD2-HMAC mechanism
        /// </summary>
        MD2_HMAC = 0x00000201,

        /// <summary>
        /// The general-length MD2-HMAC mechanism that uses the HMAC construction, based on the MD2 hash function
        /// </summary>
        MD2_HMAC_GENERAL = 0x00000202,

        /// <summary>
        /// The MD5 digesting mechanism
        /// </summary>
        MD5 = 0x00000210,

        /// <summary>
        /// Special case of the general-length MD5-HMAC mechanism
        /// </summary>
        MD5_HMAC = 0x00000211,

        /// <summary>
        /// The general-length MD5-HMAC mechanism that uses the HMAC construction, based on the MD5 hash function
        /// </summary>
        MD5_HMAC_GENERAL = 0x00000212,

        /// <summary>
        /// The SHA-1 digesting mechanism
        /// </summary>
        SHA_1 = 0x00000220,

        /// <summary>
        /// Special case of the general-length SHA1-HMAC mechanism
        /// </summary>
        SHA_1_HMAC = 0x00000221,

        /// <summary>
        /// The general-length SHA1-HMAC mechanism that uses the HMAC construction, based on the SHA1 hash function
        /// </summary>
        SHA_1_HMAC_GENERAL = 0x00000222,

        /// <summary>
        /// The RIPE-MD 128 digesting mechanism
        /// </summary>
        RIPEMD128 = 0x00000230,

        /// <summary>
        /// Special case of the general-length RIPE-MD 128-HMAC mechanism
        /// </summary>
        RIPEMD128_HMAC = 0x00000231,

        /// <summary>
        ///  The general-length RIPE-MD 128-HMAC mechanism that uses the HMAC construction, based on the RIPE-MD 128 hash function
        /// </summary>
        RIPEMD128_HMAC_GENERAL = 0x00000232,

        /// <summary>
        /// The RIPE-MD 160 digesting mechanism
        /// </summary>
        RIPEMD160 = 0x00000240,

        /// <summary>
        /// Special case of the general-length RIPE-MD 160-HMAC mechanism
        /// </summary>
        RIPEMD160_HMAC = 0x00000241,

        /// <summary>
        ///  The general-length RIPE-MD 160-HMAC mechanism that uses the HMAC construction, based on the RIPE-MD 160 hash function
        /// </summary>
        RIPEMD160_HMAC_GENERAL = 0x00000242,

        /// <summary>
        /// The SHA-256 digesting mechanism
        /// </summary>
        SHA256 = 0x00000250,

        /// <summary>
        /// Special case of the general-length SHA-256-HMAC mechanism
        /// </summary>
        SHA256_HMAC = 0x00000251,

        /// <summary>
        /// The general-length SHA-256-HMAC mechanism that uses the HMAC construction, based on the SHA-256 hash function
        /// </summary>
        SHA256_HMAC_GENERAL = 0x00000252,

        /// <summary>
        /// The SHA-224 digesting mechanism
        /// </summary>
        SHA224 = 0x00000255,

        /// <summary>
        /// Special case of the general-length SHA-224-HMAC mechanism
        /// </summary>
        SHA224_HMAC = 0x00000256,

        /// <summary>
        /// The general-length SHA-224-HMAC mechanism that uses the HMAC construction, based on the SHA-224 hash function
        /// </summary>
        SHA224_HMAC_GENERAL = 0x00000257,

        /// <summary>
        /// The SHA-384 digesting mechanism
        /// </summary>
        SHA384 = 0x00000260,

        /// <summary>
        /// Special case of the general-length SHA-384-HMAC mechanism
        /// </summary>
        SHA384_HMAC = 0x00000261,

        /// <summary>
        /// The general-length SHA-384-HMAC mechanism that uses the HMAC construction, based on the SHA-384 hash function
        /// </summary>
        SHA384_HMAC_GENERAL = 0x00000262,

        /// <summary>
        /// The SHA-512 digesting mechanism
        /// </summary>
        SHA512 = 0x00000270,

        /// <summary>
        /// Special case of the general-length SHA-512-HMAC mechanism
        /// </summary>
        SHA512_HMAC = 0x00000271,

        /// <summary>
        /// The general-length SHA-512-HMAC mechanism that uses the HMAC construction, based on the SHA-512 hash function
        /// </summary>
        SHA512_HMAC_GENERAL = 0x00000272,

        /// <summary>
        /// Key generation mechanism for the RSA SecurID algorithm
        /// </summary>
        SECURID_KEY_GEN = 0x00000280,

        /// <summary>
        /// Mechanism for the retrieval and verification of RSA SecurID OTP values
        /// </summary>
        SECURID = 0x00000282,

        /// <summary>
        /// Key generation mechanism for the HOTP algorithm
        /// </summary>
        HOTP_KEY_GEN = 0x00000290,

        /// <summary>
        /// Mechanism for the retrieval and verification of HOTP OTP values
        /// </summary>
        HOTP = 0x00000291,

        /// <summary>
        /// Mechanism for the retrieval and verification of ACTI OTP values
        /// </summary>
        ACTI = 0x000002A0,

        /// <summary>
        /// Key generation mechanism for the ACTI algorithm
        /// </summary>
        ACTI_KEY_GEN = 0x000002A1,

        /// <summary>
        /// CAST key generation mechanism
        /// </summary>
        CAST_KEY_GEN = 0x00000300,

        /// <summary>
        /// CAST-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAST_ECB = 0x00000301,

        /// <summary>
        /// CAST-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAST_CBC = 0x00000302,

        /// <summary>
        /// Special case of general-length CAST-MAC mechanism
        /// </summary>
        CAST_MAC = 0x00000303,

        /// <summary>
        /// General-length CAST-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CAST_MAC_GENERAL = 0x00000304,

        /// <summary>
        /// CAST-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CAST_CBC_PAD = 0x00000305,

        /// <summary>
        /// CAST3 key generation mechanism
        /// </summary>
        CAST3_KEY_GEN = 0x00000310,

        /// <summary>
        /// CAST3-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAST3_ECB = 0x00000311,

        /// <summary>
        /// CAST3-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAST3_CBC = 0x00000312,

        /// <summary>
        /// Special case of general-length CAST3-MAC mechanism
        /// </summary>
        CAST3_MAC = 0x00000313,

        /// <summary>
        /// General-length CAST3-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CAST3_MAC_GENERAL = 0x00000314,

        /// <summary>
        /// CAST3-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CAST3_CBC_PAD = 0x00000315,

        /// <summary>
        /// CAST128 key generation mechanism
        /// </summary>
        CAST5_KEY_GEN = 0x00000320,

        /// <summary>
        /// CAST128 key generation mechanism
        /// </summary>
        CAST128_KEY_GEN = 0x00000320,

        /// <summary>
        /// CAST128-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAST5_ECB = 0x00000321,

        /// <summary>
        /// CAST128-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAST128_ECB = 0x00000321,

        /// <summary>
        /// CAST128-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAST5_CBC = 0x00000322,

        /// <summary>
        /// CAST128-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAST128_CBC = 0x00000322,

        /// <summary>
        /// Special case of general-length CAST128-MAC mechanism
        /// </summary>
        CAST5_MAC = 0x00000323,

        /// <summary>
        /// Special case of general-length CAST128-MAC mechanism
        /// </summary>
        CAST128_MAC = 0x00000323,

        /// <summary>
        /// General-length CAST128-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CAST5_MAC_GENERAL = 0x00000324,

        /// <summary>
        /// General-length CAST128-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CAST128_MAC_GENERAL = 0x00000324,

        /// <summary>
        /// CAST128-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CAST5_CBC_PAD = 0x00000325,

        /// <summary>
        /// CAST128-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CAST128_CBC_PAD = 0x00000325,

        /// <summary>
        /// RC5 key generation mechanism
        /// </summary>
        RC5_KEY_GEN = 0x00000330,

        /// <summary>
        /// RC5-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        RC5_ECB = 0x00000331,

        /// <summary>
        /// RC5-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        RC5_CBC = 0x00000332,

        /// <summary>
        /// Special case of general-length RC5-MAC mechanism
        /// </summary>
        RC5_MAC = 0x00000333,

        /// <summary>
        /// General-length RC5-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        RC5_MAC_GENERAL = 0x00000334,

        /// <summary>
        /// RC5-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        RC5_CBC_PAD = 0x00000335,

        /// <summary>
        /// IDEA key generation mechanism
        /// </summary>
        IDEA_KEY_GEN = 0x00000340,

        /// <summary>
        /// IDEA-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        IDEA_ECB = 0x00000341,

        /// <summary>
        /// IDEA-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        IDEA_CBC = 0x00000342,

        /// <summary>
        /// Special case of general-length IDEA-MAC mechanism
        /// </summary>
        IDEA_MAC = 0x00000343,

        /// <summary>
        /// General-length IDEA-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        IDEA_MAC_GENERAL = 0x00000344,

        /// <summary>
        /// IDEA-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        IDEA_CBC_PAD = 0x00000345,

        /// <summary>
        /// The generic secret key generation mechanism
        /// </summary>
        GENERIC_SECRET_KEY_GEN = 0x00000350,

        /// <summary>
        /// Key derivation mechanism that derives a secret key from the concatenation of two existing secret keys
        /// </summary>
        CONCATENATE_BASE_AND_KEY = 0x00000360,

        /// <summary>
        /// Key derivation mechanism that derives a secret key by concatenating data onto the end of a specified secret key
        /// </summary>
        CONCATENATE_BASE_AND_DATA = 0x00000362,

        /// <summary>
        /// Key derivation mechanism that derives a secret key by prepending data to the start of a specified secret key
        /// </summary>
        CONCATENATE_DATA_AND_BASE = 0x00000363,

        /// <summary>
        /// Key derivation mechanism that 
        /// </summary>
        XOR_BASE_AND_DATA = 0x00000364,

        /// <summary>
        /// Mechanism which provides the capability of creating one secret key from the bits of another secret key
        /// </summary>
        EXTRACT_KEY_FROM_KEY = 0x00000365,

        /// <summary>
        /// Mechanism for pre_master key generation in SSL 3.0
        /// </summary>
        SSL3_PRE_MASTER_KEY_GEN = 0x00000370,

        /// <summary>
        /// Mechanism for master key derivation in SSL 3.0
        /// </summary>
        SSL3_MASTER_KEY_DERIVE = 0x00000371,

        /// <summary>
        /// Mechanism for key, MAC and IV derivation in SSL 3.0
        /// </summary>
        SSL3_KEY_AND_MAC_DERIVE = 0x00000372,

        /// <summary>
        /// Mechanism for master key derivation for Diffie-Hellman in SSL 3.0
        /// </summary>
        SSL3_MASTER_KEY_DERIVE_DH = 0x00000373,

        /// <summary>
        /// Mechanism for pre-master key generation in TLS 1.0,
        /// </summary>
        TLS_PRE_MASTER_KEY_GEN = 0x00000374,

        /// <summary>
        /// Mechanism for master key derivation in TLS 1.0
        /// </summary>
        TLS_MASTER_KEY_DERIVE = 0x00000375,

        /// <summary>
        /// Mechanism for key, MAC and IV derivation in TLS 1.0
        /// </summary>
        TLS_KEY_AND_MAC_DERIVE = 0x00000376,

        /// <summary>
        /// Mechanism for master key derivation for Diffie-Hellman in TLS 1.0
        /// </summary>
        TLS_MASTER_KEY_DERIVE_DH = 0x00000377,

        /// <summary>
        /// PRF (pseudo random function) in TLS
        /// </summary>
        TLS_PRF = 0x00000378,

        /// <summary>
        /// Mechanism for MD5 MACing in SSL3.0
        /// </summary>
        SSL3_MD5_MAC = 0x00000380,

        /// <summary>
        /// Mechanism for SHA-1 MACing in SSL3.0
        /// </summary>
        SSL3_SHA1_MAC = 0x00000381,

        /// <summary>
        /// MD5 key derivation mechanism
        /// </summary>
        MD5_KEY_DERIVATION = 0x00000390,

        /// <summary>
        /// MD2 key derivation mechanism
        /// </summary>
        MD2_KEY_DERIVATION = 0x00000391,

        /// <summary>
        /// SHA-1 key derivation mechanism
        /// </summary>
        SHA1_KEY_DERIVATION = 0x00000392,

        /// <summary>
        /// SHA-256 key derivation mechanism
        /// </summary>
        SHA256_KEY_DERIVATION = 0x00000393,

        /// <summary>
        /// SHA-384 key derivation mechanism
        /// </summary>
        SHA384_KEY_DERIVATION = 0x00000394,

        /// <summary>
        /// SHA-512 key derivation mechanism
        /// </summary>
        SHA512_KEY_DERIVATION = 0x00000395,

        /// <summary>
        /// SHA-224 key derivation mechanism
        /// </summary>
        SHA224_KEY_DERIVATION = 0x00000396,

        /// <summary>
        /// MD2-PBE for DES-CBC mechanism used for generating a DES secret key and an IV from a password and a salt value by using the MD2 digest algorithm and an iteration count. This functionality is defined in PKCS#5 as PBKDF1.
        /// </summary>
        PBE_MD2_DES_CBC = 0x000003A0,

        /// <summary>
        /// MD5-PBE for DES-CBC mechanism used for generating a DES secret key and an IV from a password and a salt value by using the MD5 digest algorithm and an iteration count. This functionality is defined in PKCS#5 as PBKDF1.
        /// </summary>
        PBE_MD5_DES_CBC = 0x000003A1,

        /// <summary>
        /// MD5-PBE for CAST-CBC mechanism used for generating a CAST secret key and an IV from a password and a salt value by using the MD5 digest algorithm and an iteration count.
        /// </summary>
        PBE_MD5_CAST_CBC = 0x000003A2,

        /// <summary>
        /// MD5-PBE for CAST3-CBC mechanism used for generating a CAST3 secret key and an IV from a password and a salt value by using the MD5 digest algorithm and an iteration count.
        /// </summary>
        PBE_MD5_CAST3_CBC = 0x000003A3,

        /// <summary>
        /// MD5-PBE for CAST128-CBC (CAST5-CBC) mechanism used for generating a CAST128 (CAST5) secret key and an IV from a password and a salt value by using the MD5 digest algorithm and an iteration count.
        /// </summary>
        PBE_MD5_CAST5_CBC = 0x000003A4,

        /// <summary>
        /// MD5-PBE for CAST128-CBC mechanism used for generating a CAST128 secret key and an IV from a password and a salt value by using the MD5 digest algorithm and an iteration count.
        /// </summary>
        PBE_MD5_CAST128_CBC = 0x000003A4,

        /// <summary>
        /// SHA-1-PBE for CAST128-CBC (CAST5-CBC) mechanism used for generating a CAST128 (CAST5) secret key and an IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_CAST5_CBC = 0x000003A5,

        /// <summary>
        /// SHA-1-PBE for CAST128-CBC mechanism used for generating a CAST128 secret key and an IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_CAST128_CBC = 0x000003A5,

        /// <summary>
        /// SHA-1-PBE for 128-bit RC4 mechanism used for generating a 128-bit RC4 secret key from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_RC4_128 = 0x000003A6,

        /// <summary>
        /// SHA-1-PBE for 40-bit RC4 mechanism used for generating a 40-bit RC4 secret key from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_RC4_40 = 0x000003A7,

        /// <summary>
        /// SHA-1-PBE for 3-key triple-DES-CBC mechanism used for generating a 3-key triple-DES secret key and IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_DES3_EDE_CBC = 0x000003A8,

        /// <summary>
        /// SHA-1-PBE for 2-key triple-DES-CBC mechanism used for generating a 2-key triple-DES secret key and IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_DES2_EDE_CBC = 0x000003A9,

        /// <summary>
        /// SHA-1-PBE for 128-bit RC2-CBC mechanism used for generating a 128-bit RC2 secret key and IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_RC2_128_CBC = 0x000003AA,

        /// <summary>
        /// SHA-1-PBE for 40-bit RC2-CBC mechanism used for generating a 40-bit RC2 secret key and IV from a password and a salt value by using the SHA-1 digest algorithm and an iteration count.
        /// </summary>
        PBE_SHA1_RC2_40_CBC = 0x000003AB,

        /// <summary>
        /// PKCS #5 PBKDF2 key generation mechanism used for generating a secret key from a password and a salt value
        /// </summary>
        PKCS5_PBKD2 = 0x000003B0,

        /// <summary>
        /// SHA-1-PBA for SHA-1-HMAC mechanism used for generating a 160-bit generic secret key from a password and a salt value by using the SHA-1 digest algorithm and an iteration count
        /// </summary>
        PBA_SHA1_WITH_SHA1_HMAC = 0x000003C0,

        /// <summary>
        /// Mechanism for pre-master secret key generation for the RSA key exchange suite in WTLS
        /// </summary>
        WTLS_PRE_MASTER_KEY_GEN = 0x000003D0,

        /// <summary>
        /// Mechanism for master secret derivation in WTLS
        /// </summary>
        WTLS_MASTER_KEY_DERIVE = 0x000003D1,

        /// <summary>
        /// Mechanism for master secret derivation for Diffie-Hellman and Elliptic Curve Cryptography in WTLS
        /// </summary>
        WTLS_MASTER_KEY_DERIVE_DH_ECC = 0x000003D2,

        /// <summary>
        /// PRF (pseudo random function) in WTLS
        /// </summary>
        WTLS_PRF = 0x000003D3,

        /// <summary>
        /// Mechanism for server key, MAC and IV derivation in WTLS
        /// </summary>
        WTLS_SERVER_KEY_AND_MAC_DERIVE = 0x000003D4,

        /// <summary>
        /// Mechanism for client key, MAC and IV derivation in WTLS
        /// </summary>
        WTLS_CLIENT_KEY_AND_MAC_DERIVE = 0x000003D5,

        /// <summary>
        /// Mechanism is defined in PKCS#11 v2.40e1 headers but the description is not present in the specification
        /// </summary>
        TLS10_MAC_SERVER = 0x000003D6, // TODO - Fix description when fixed in PKCS#11 specification

        /// <summary>
        /// Mechanism is defined in PKCS#11 v2.40e1 headers but the description is not present in the specification
        /// </summary>
        TLS10_MAC_CLIENT = 0x000003D7, // TODO - Fix description when fixed in PKCS#11 specification

        /// <summary>
        /// Mechanism is defined in PKCS#11 v2.40e1 headers but the description is not present in the specification
        /// </summary>
        TLS12_MAC = 0x000003D8, // TODO - Fix description when fixed in PKCS#11 specification

        /// <summary>
        /// Mechanism is defined in PKCS#11 v2.40e1 headers but the description is not present in the specification
        /// </summary>
        TLS12_KDF = 0x000003D9, // TODO - Fix description when fixed in PKCS#11 specification

        /// <summary>
        /// Mechanism for master key derivation in TLS 1.2
        /// </summary>
        TLS12_MASTER_KEY_DERIVE = 0x000003E0,

        /// <summary>
        /// Mechanism for key, MAC and IV derivation in TLS 1.2
        /// </summary>
        TLS12_KEY_AND_MAC_DERIVE = 0x000003E1,

        /// <summary>
        /// Mechanism for master key derivation for Diffie-Hellman in TLS 1.2
        /// </summary>
        TLS12_MASTER_KEY_DERIVE_DH = 0x000003E2,

        /// <summary>
        /// Mechanism that is identical to TLS12_KEY_AND_MAC_DERIVE except that it shall never produce IV data
        /// </summary>
        TLS12_KEY_SAFE_DERIVE = 0x000003E3,

        /// <summary>
        /// Mechanism for generation of integrity tags for the TLS "finished" message
        /// </summary>
        TLS_MAC = 0x000003E4,

        /// <summary>
        /// Mechanism that uses the TLS key material and TLS PRF function to produce additional key material for protocols that want to leverage the TLS key negotiation mechanism
        /// </summary>
        TLS_KDF = 0x000003E5,

        /// <summary>
        /// The LYNKS key wrapping mechanism
        /// </summary>
        KEY_WRAP_LYNKS = 0x00000400,

        /// <summary>
        /// The OAEP key wrapping for SET mechanism
        /// </summary>
        KEY_WRAP_SET_OAEP = 0x00000401,

        /// <summary>
        /// The CMS mechanism
        /// </summary>
        CMS_SIG = 0x00000500,

        /// <summary>
        /// The CT-KIP key derivation mechanism
        /// </summary>
        KIP_DERIVE = 0x00000510,

        /// <summary>
        /// The CT-KIP key wrap and unwrap mechanism
        /// </summary>
        KIP_WRAP = 0x00000511,

        /// <summary>
        /// The CT-KIP signature (MAC) mechanism
        /// </summary>
        KIP_MAC = 0x00000512,

        /// <summary>
        /// The Camellia key generation mechanism
        /// </summary>
        CAMELLIA_KEY_GEN = 0x00000550,

        /// <summary>
        /// Camellia-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAMELLIA_ECB = 0x00000551,

        /// <summary>
        /// Camellia-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAMELLIA_CBC = 0x00000552,

        /// <summary>
        /// Special case of general-length Camellia-MAC mechanism
        /// </summary>
        CAMELLIA_MAC = 0x00000553,

        /// <summary>
        /// General-length Camellia-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        CAMELLIA_MAC_GENERAL = 0x00000554,

        /// <summary>
        /// Camellia-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        CAMELLIA_CBC_PAD = 0x00000555,

        /// <summary>
        /// Key derivation mechanism based on Camellia-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        CAMELLIA_ECB_ENCRYPT_DATA = 0x00000556,

        /// <summary>
        /// Key derivation mechanism based on Camellia-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        CAMELLIA_CBC_ENCRYPT_DATA = 0x00000557,

        /// <summary>
        /// Camellia-CTR mechanism for encryption and decryption with CAMELLIA in counter mode
        /// </summary>
        CAMELLIA_CTR = 0x00000558,

        /// <summary>
        /// The ARIA key generation mechanism
        /// </summary>
        ARIA_KEY_GEN = 0x00000560,

        /// <summary>
        /// ARIA-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        ARIA_ECB = 0x00000561,

        /// <summary>
        /// ARIA-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        ARIA_CBC = 0x00000562,

        /// <summary>
        /// Special case of general-length ARIA-MAC mechanism
        /// </summary>
        ARIA_MAC = 0x00000563,

        /// <summary>
        /// General-length ARIA-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        ARIA_MAC_GENERAL = 0x00000564,

        /// <summary>
        /// ARIA-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        ARIA_CBC_PAD = 0x00000565,

        /// <summary>
        /// Key derivation mechanism based on ARIA-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        ARIA_ECB_ENCRYPT_DATA = 0x00000566,

        /// <summary>
        /// Key derivation mechanism based on ARIA-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        ARIA_CBC_ENCRYPT_DATA = 0x00000567,

        /// <summary>
        /// The SEED key generation mechanism
        /// </summary>
        SEED_KEY_GEN = 0x00000650,

        /// <summary>
        /// SEED-ECB encryption mechanims with electronic codebook mode (ECB)
        /// </summary>
        SEED_ECB = 0x00000651,

        /// <summary>
        /// SEED-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        SEED_CBC = 0x00000652,

        /// <summary>
        /// Special case of general-length SEED-MAC mechanism
        /// </summary>
        SEED_MAC = 0x00000653,

        /// <summary>
        /// General-length SEED-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        SEED_MAC_GENERAL = 0x00000654,

        /// <summary>
        /// SEED-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        SEED_CBC_PAD = 0x00000655,

        /// <summary>
        /// Key derivation mechanism based on SEED-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        SEED_ECB_ENCRYPT_DATA = 0x00000656,

        /// <summary>
        /// Key derivation mechanism based on SEED-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        SEED_CBC_ENCRYPT_DATA = 0x00000657,

        /// <summary>
        /// The SKIPJACK key generation mechanism
        /// </summary>
        SKIPJACK_KEY_GEN = 0x00001000,

        /// <summary>
        /// SKIPJACK-ECB64 mechanism for encryption and decryption with SKIPJACK in 64-bit electronic codebook mode (ECB)
        /// </summary>
        SKIPJACK_ECB64 = 0x00001001,

        /// <summary>
        /// SKIPJACK-CBC64 mechanism for encryption and decryption with SKIPJACK in 64-bit cipher-block chaining mode (CBC)
        /// </summary>
        SKIPJACK_CBC64 = 0x00001002,

        /// <summary>
        /// SKIPJACK-OFB64 mechanism for encryption and decryption with SKIPJACK in 64-bit output feedback mode (OFB)
        /// </summary>
        SKIPJACK_OFB64 = 0x00001003,

        /// <summary>
        /// SKIPJACK-CFB64 mechanism for encryption and decryption with SKIPJACK in 64-bit cipher feedback mode (CFB)
        /// </summary>
        SKIPJACK_CFB64 = 0x00001004,

        /// <summary>
        /// SKIPJACK-CFB32 mechanism for encryption and decryption with SKIPJACK in 32-bit cipher feedback mode (CFB)
        /// </summary>
        SKIPJACK_CFB32 = 0x00001005,

        /// <summary>
        /// SKIPJACK-CFB16 mechanism for encryption and decryption with SKIPJACK in 16-bit cipher feedback mode (CFB)
        /// </summary>
        SKIPJACK_CFB16 = 0x00001006,

        /// <summary>
        /// SKIPJACK-CFB8 mechanism for encryption and decryption with SKIPJACK in 8-bit cipher feedback mode (CFB)
        /// </summary>
        SKIPJACK_CFB8 = 0x00001007,

        /// <summary>
        /// SKIPJACK mechanism for wrapping and unwrapping of secret keys (MEK)
        /// </summary>
        SKIPJACK_WRAP = 0x00001008,

        /// <summary>
        /// Mechanism for wrapping and unwrapping KEA and DSA private keys
        /// </summary>
        SKIPJACK_PRIVATE_WRAP = 0x00001009,

        /// <summary>
        /// Mechanism for "change of wrapping" on a private key which was wrapped with the SKIPJACK-PRIVATE-WRAP mechanism
        /// </summary>
        SKIPJACK_RELAYX = 0x0000100a,

        /// <summary>
        /// The KEA key pair generation mechanism
        /// </summary>
        KEA_KEY_PAIR_GEN = 0x00001010,

        /// <summary>
        /// The KEA key derivation mechanism
        /// </summary>
        KEA_KEY_DERIVE = 0x00001011,

        /// <summary>
        /// The KEA key derivation mechanism
        /// </summary>
        KEA_DERIVE = 0x00001012,

        /// <summary>
        /// The FORTEZZA timestamp mechanism
        /// </summary>
        FORTEZZA_TIMESTAMP = 0x00001020,

        /// <summary>
        /// The BATON key generation mechanism
        /// </summary>
        BATON_KEY_GEN = 0x00001030,

        /// <summary>
        /// BATON-ECB128 mechanism for encryption and decryption with BATON in 128-bit electronic codebook mode (ECB)
        /// </summary>
        BATON_ECB128 = 0x00001031,

        /// <summary>
        /// BATON-ECB96 mechanism for encryption and decryption with BATON in 96-bit electronic codebook mode (ECB)
        /// </summary>
        BATON_ECB96 = 0x00001032,

        /// <summary>
        /// BATON-CBC128 mechanism for encryption and decryption with BATON in 128-bit cipher-block chaining mode (CBC)
        /// </summary>
        BATON_CBC128 = 0x00001033,

        /// <summary>
        /// BATON-COUNTER mechanism encryption and decryption with BATON in counter mode
        /// </summary>
        BATON_COUNTER = 0x00001034,

        /// <summary>
        /// BATON-SHUFFLE mechanism for encryption and decryption with BATON in shuffle mode
        /// </summary>
        BATON_SHUFFLE = 0x00001035,

        /// <summary>
        /// BATON mechanism for wrapping and unwrapping of secret keys (MEK)
        /// </summary>
        BATON_WRAP = 0x00001036,

        /// <summary>
        /// The EC (also related to ECDSA) key pair generation mechanism
        /// </summary>
        ECDSA_KEY_PAIR_GEN = 0x00001040,

        /// <summary>
        /// The EC (also related to ECDSA) key pair generation mechanism
        /// </summary>
        EC_KEY_PAIR_GEN = 0x00001040,

        /// <summary>
        /// The ECDSA without hashing mechanism
        /// </summary>
        ECDSA = 0x00001041,

        /// <summary>
        /// The ECDSA with SHA-1 mechanism
        /// </summary>
        ECDSA_SHA1 = 0x00001042,

        /// <summary>
        /// The ECDSA with SHA-224 mechanism
        /// </summary>
        ECDSA_SHA224 = 0x00001043,

        /// <summary>
        /// The ECDSA with SHA-256 mechanism
        /// </summary>
        ECDSA_SHA256 = 0x00001044,

        /// <summary>
        /// The ECDSA with SHA-384 mechanism
        /// </summary>
        ECDSA_SHA384 = 0x00001045,

        /// <summary>
        /// The ECDSA with SHA-512 mechanism
        /// </summary>
        ECDSA_SHA512 = 0x00001046,

        /// <summary>
        /// The elliptic curve Diffie-Hellman (ECDH) key derivation mechanism
        /// </summary>
        ECDH1_DERIVE = 0x00001050,

        /// <summary>
        /// The elliptic curve Diffie-Hellman (ECDH) with cofactor key derivation mechanism
        /// </summary>
        ECDH1_COFACTOR_DERIVE = 0x00001051,

        /// <summary>
        /// The elliptic curve Menezes-Qu-Vanstone (ECMQV) key derivation mechanism
        /// </summary>
        ECMQV_DERIVE = 0x00001052,

        /// <summary>
        /// Mechanism based on the EC public-key cryptosystem and the AES key wrap mechanism
        /// </summary>
        ECDH_AES_KEY_WRAP = 0x00001053,

        /// <summary>
        /// Mechanism based on the RSA public-key cryptosystem and the AES key wrap mechanism
        /// </summary>
        RSA_AES_KEY_WRAP = 0x00001054,

        /// <summary>
        /// The JUNIPER key generation mechanism
        /// </summary>
        JUNIPER_KEY_GEN = 0x00001060,

        /// <summary>
        /// JUNIPER-ECB128 mechanism for encryption and decryption with JUNIPER in 128-bit electronic codebook mode (ECB)
        /// </summary>
        JUNIPER_ECB128 = 0x00001061,

        /// <summary>
        /// JUNIPER-CBC128 mechanism for encryption and decryption with JUNIPER in 128-bit cipher-block chaining mode (CBC)
        /// </summary>
        JUNIPER_CBC128 = 0x00001062,

        /// <summary>
        /// JUNIPER COUNTER mechanism for encryption and decryption with JUNIPER in counter mode
        /// </summary>
        JUNIPER_COUNTER = 0x00001063,

        /// <summary>
        /// JUNIPER-SHUFFLE mechanism for encryption and decryption with JUNIPER in shuffle mode
        /// </summary>
        JUNIPER_SHUFFLE = 0x00001064,

        /// <summary>
        /// The JUNIPER wrap and unwrap mechanism used to wrap and unwrap an MEK
        /// </summary>
        JUNIPER_WRAP = 0x00001065,

        /// <summary>
        /// The FASTHASH digesting mechanism
        /// </summary>
        FASTHASH = 0x00001070,

        /// <summary>
        /// The AES key generation mechanism
        /// </summary>
        AES_KEY_GEN = 0x00001080,

        /// <summary>
        /// AES-ECB encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        AES_ECB = 0x00001081,

        /// <summary>
        /// AES-CBC encryption mechanism with cipher-block chaining mode (CBC)
        /// </summary>
        AES_CBC = 0x00001082,

        /// <summary>
        /// Special case of general-length AES-MAC mechanism
        /// </summary>
        AES_MAC = 0x00001083,

        /// <summary>
        /// General-length AES-MAC mechanism based on data authentication as defined in FIPS PUB 113
        /// </summary>
        AES_MAC_GENERAL = 0x00001084,

        /// <summary>
        /// AES-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        AES_CBC_PAD = 0x00001085,

        /// <summary>
        /// AES-CTR encryption mechanism with AES in counter mode
        /// </summary>
        AES_CTR = 0x00001086,

        /// <summary>
        /// AES-GCM authenticated encryption
        /// </summary>
        AES_GCM = 0x00001087,

        /// <summary>
        /// AES-CCM authenticated encryption
        /// </summary>
        AES_CCM = 0x00001088,

        /// <summary>
        /// AES CBC encryption with Cipher Text Stealing CTS
        /// </summary>
        AES_CTS = 0x00001089,

        /// <summary>
        /// Special case of general-length AES-CMAC mechanism based on Cipher-based Message Authenticate Code as defined in NIST SP 800-38B and RFC 4493
        /// </summary>
        AES_CMAC = 0x0000108A,

        /// <summary>
        /// General-length AES-CMAC mechanism based on Cipher-based Message Authenticate Code as defined in NIST SP 800-38B and RFC 4493
        /// </summary>
        AES_CMAC_GENERAL = 0x0000108B,

        /// <summary>
        /// AES-XCBC-MAC signing and verification mechanism based on NIST AES and RFC 3566
        /// </summary>
        AES_XCBC_MAC = 0x0000108C,

        /// <summary>
        /// AES-XCBC-MAC-96 signing and verification mechanism based on NIST AES and RFC 3566
        /// </summary>
        AES_XCBC_MAC_96 = 0x0000108D,

        /// <summary>
        /// AES-GMAC signing and verification mechanism described in NIST SP 800-38D
        /// </summary>
        AES_GMAC = 0x0000108E,

        /// <summary>
        /// The Blowfish key generation mechanism
        /// </summary>
        BLOWFISH_KEY_GEN = 0x00001090,

        /// <summary>
        /// Blowfish-CBC mechanism for encryption and decryption; key wrapping; and key unwrapping
        /// </summary>
        BLOWFISH_CBC = 0x00001091,

        /// <summary>
        /// The Twofish key generation mechanism
        /// </summary>
        TWOFISH_KEY_GEN = 0x00001092,

        /// <summary>
        /// Twofish-CBC mechanism for encryption and decryption; key wrapping; and key unwrapping
        /// </summary>
        TWOFISH_CBC = 0x00001093,

        /// <summary>
        /// Blowfish-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        BLOWFISH_CBC_PAD = 0x00001094,

        /// <summary>
        /// Twofish-CBC encryption mechanism with cipher-block chaining mode (CBC) and PKCS#7 padding
        /// </summary>
        TWOFISH_CBC_PAD = 0x00001095,

        /// <summary>
        /// Key derivation mechanism that uses the result of an DES-ECB encryption operation as the key value
        /// </summary>
        DES_ECB_ENCRYPT_DATA = 0x00001100,

        /// <summary>
        /// Key derivation mechanism that uses the result of an DES-CBC encryption operation as the key value
        /// </summary>
        DES_CBC_ENCRYPT_DATA = 0x00001101,

        /// <summary>
        /// Key derivation mechanism that uses the result of an DES3-ECB encryption operation as the key value
        /// </summary>
        DES3_ECB_ENCRYPT_DATA = 0x00001102,

        /// <summary>
        /// Key derivation mechanism that uses the result of an DES3-CBC encryption operation as the key value
        /// </summary>
        DES3_CBC_ENCRYPT_DATA = 0x00001103,

        /// <summary>
        /// Key derivation mechanism that uses the result of an AES-ECB encryption operation as the key value
        /// </summary>
        AES_ECB_ENCRYPT_DATA = 0x00001104,

        /// <summary>
        /// Key derivation mechanism that uses the result of an AES-CBC encryption operation as the key value
        /// </summary>
        AES_CBC_ENCRYPT_DATA = 0x00001105,

        /// <summary>
        /// GOST R 34.10-2001 key generation
        /// </summary>
        GOSTR3410_KEY_PAIR_GEN = 0x00001200,

        /// <summary>
        /// GOST R 34.10-2001 signing and verification without hashing
        /// </summary>
        GOSTR3410 = 0x00001201,

        /// <summary>
        /// GOST R 34.10-2001 signing and verification with GOST R 34.11-94 hashing
        /// </summary>
        GOSTR3410_WITH_GOSTR3411 = 0x00001202,

        /// <summary>
        /// GOST R 34.10-2001 based mechanims for GOST 28147-89 key wrapping
        /// </summary>
        GOSTR3410_KEY_WRAP = 0x00001203,

        /// <summary>
        /// GOST R 34.10-2001 based key derivation mechanim
        /// </summary>
        GOSTR3410_DERIVE = 0x00001204,

        /// <summary>
        /// GOST R 34.11-94 digesting mechanism
        /// </summary>
        GOSTR3411 = 0x00001210,

        /// <summary>
        /// GOST R 34.11-94 based mechanism for HMAC construction
        /// </summary>
        GOSTR3411_HMAC = 0x00001211,

        /// <summary>
        /// GOST 28147-89 key generation
        /// </summary>
        GOST28147_KEY_GEN = 0x00001220,

        /// <summary>
        /// GOST 28147-89 encryption mechanism with electronic codebook mode (ECB)
        /// </summary>
        GOST28147_ECB = 0x00001221,

        /// <summary>
        /// GOST 28147-89 encryption mechanism with with cipher feedback mode (CFB) and additional CBC mode defined in section 2 of RFC 4357
        /// </summary>
        GOST28147 = 0x00001222,

        /// <summary>
        /// GOST 28147-89-MAC mechanism for data integrity and authentication based on GOST 28147-89 and key meshing algorithms defined in section 2.3 of RFC 4357
        /// </summary>
        GOST28147_MAC = 0x00001223,

        /// <summary>
        /// GOST 28147-89 based mechanims for GOST 28147-89 key wrapping
        /// </summary>
        GOST28147_KEY_WRAP = 0x00001224,

        /// <summary>
        /// The DSA domain parameter generation mechanism
        /// </summary>
        DSA_PARAMETER_GEN = 0x00002000,

        /// <summary>
        /// The PKCS #3 Diffie-Hellman domain parameter generation mechanism
        /// </summary>
        DH_PKCS_PARAMETER_GEN = 0x00002001,

        /// <summary>
        /// The X9.42 Diffie-Hellman domain parameter generation mechanism
        /// </summary>
        X9_42_DH_PARAMETER_GEN = 0x00002002,

        /// <summary>
        /// The DSA probabilistic domain parameter generation mechanism based on the DSA defined in Appendix A.1.1 of FIPS PUB 186-4
        /// </summary>
        DSA_PROBABLISTIC_PARAMETER_GEN = 0x00002003,

        /// <summary>
        /// The DSA Shawe-Taylor domain parameter generation mechanism based on the DSA defined in Appendix A.1.2 of FIPS PUB 186-4
        /// </summary>
        DSA_SHAWE_TAYLOR_PARAMETER_GEN = 0x00002004,

        /// <summary>
        /// AES-OFB encryption mechanism with output feedback mode (OFB)
        /// </summary>
        AES_OFB = 0x00002104,

        /// <summary>
        /// AES-CFB64 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        AES_CFB64 = 0x00002105,

        /// <summary>
        /// AES-CFB8 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        AES_CFB8 = 0x00002106,

        /// <summary>
        /// AES-CFB128 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        AES_CFB128 = 0x00002107,

        /// <summary>
        /// AES-CFB1 encryption mechanism with cipher feedback mode (CFB)
        /// </summary>
        AES_CFB1 = 0x00002108,

        /// <summary>
        /// AES key wrapping mechanism  without padding
        /// </summary>
        AES_KEY_WRAP = 0x00002109,

        /// <summary>
        /// AES key wrapping mechanism with padding
        /// </summary>
        AES_KEY_WRAP_PAD = 0x0000210A,

        /// <summary>
        /// Multi-purpose mechanism based on the RSA public-key cryptosystem and the block formats initially defined in PKCS#1 v1.5, with additional formatting rules defined in TCPA TPM Specification Version 1.1b
        /// </summary>
        RSA_PKCS_TPM_1_1 = 0x00004001,

        /// <summary>
        /// Multi-purpose mechanism based on the RSA public-key cryptosystem and the OAEP block format defined in PKCS #1, with additional formatting defined in TCPA TPM Specification Version 1.1b
        /// </summary>
        RSA_PKCS_OAEP_TPM_1_1 = 0x00004002,

        /// <summary>
        /// Permanently reserved for token vendors
        /// </summary>
        VENDOR_DEFINED = 0x80000000

    }
}
