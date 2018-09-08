// Project: Pkcs11Gram.Core
// File: AttributeType.cs
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
    /// CK_ATTRIBUTE_TYPE
    /// </summary>
    public enum AttributeType : UInt32
    {
        /// <summary>
        /// Identifies attribute whose value is an array of attributes
        /// </summary>
        ARRAY_ATTRIBUTE = 0x40000000,

        /// <summary>
        /// Object class (type) [CKO/uint]
        /// </summary>
        CLASS = 0x00000000,

        /// <summary>
        /// True if object is a token object; false if object is a session object [bool]
        /// </summary>
        TOKEN = 0x00000001,

        /// <summary>
        /// True if object is a private object; false if object is a public object. [bool]
        /// </summary>
        PRIVATE = 0x00000002,

        /// <summary>
        /// Description of the object [string]
        /// </summary>
        LABEL = 0x00000003,

        /// <summary>
        /// Description of the application that manages the object [string]
        /// </summary>
        APPLICATION = 0x00000010,

        /// <summary>
        /// Value of the object [byte array]
        /// </summary>
        VALUE = 0x00000011,

        /// <summary>
        /// DER-encoding of the object identifier indicating the data object type [byte array]
        /// </summary>
        OBJECT_ID = 0x00000012,

        /// <summary>
        /// Type of certificate [CKC/uint]
        /// </summary>
        CERTIFICATE_TYPE = 0x00000080,

        /// <summary>
        /// DER-encoding of the certificate issuer name [byte array]
        /// </summary>
        ISSUER = 0x00000081,

        /// <summary>
        /// DER-encoding of the certificate serial number [byte array]
        /// </summary>
        SERIAL_NUMBER = 0x00000082,

        /// <summary>
        /// DER-encoding of the attribute certificate's issuer field. [byte array]
        /// </summary>
        AC_ISSUER = 0x00000083,

        /// <summary>
        /// DER-encoding of the attribute certificate's subject field. [byte array]
        /// </summary>
        OWNER = 0x00000084,

        /// <summary>
        /// BER-encoding of a sequence of object identifier values corresponding to the attribute types contained in the certificate. [byte array]
        /// </summary>
        ATTR_TYPES = 0x00000085,

        /// <summary>
        /// The certificate can be trusted for the application that it was created. [bool]
        /// </summary>
        TRUSTED = 0x00000086,

        /// <summary>
        /// Categorization of the certificate [uint]
        /// </summary>
        CERTIFICATE_CATEGORY = 0x00000087,

        /// <summary>
        /// Java MIDP security domain [uint]
        /// </summary>
        JAVA_MIDP_SECURITY_DOMAIN = 0x00000088,

        /// <summary>
        /// If not empty this attribute gives the URL where the complete certificate can be obtained [string]
        /// </summary>
        URL = 0x00000089,

        /// <summary>
        /// SHA-1 hash of the subject public key [byte array]
        /// </summary>
        HASH_OF_SUBJECT_PUBLIC_KEY = 0x0000008A,

        /// <summary>
        /// SHA-1 hash of the issuer public key [byte array]
        /// </summary>
        HASH_OF_ISSUER_PUBLIC_KEY = 0x0000008B,

        /// <summary>
        /// Checksum [byte array]
        /// </summary>
        CHECK_VALUE = 0x00000090,

        /// <summary>
        /// Type of key [CKK/uint]
        /// </summary>
        KEY_TYPE = 0x00000100,

        /// <summary>
        /// DER-encoding of the key subject name [byte array]
        /// </summary>
        SUBJECT = 0x00000101,

        /// <summary>
        /// Key identifier for public/private key pair [byte array]
        /// </summary>
        ID = 0x00000102,

        /// <summary>
        /// True if key is sensitive [bool]
        /// </summary>
        SENSITIVE = 0x00000103,

        /// <summary>
        /// True if key supports encryption [bool]
        /// </summary>
        ENCRYPT = 0x00000104,

        /// <summary>
        /// True if key supports decryption [bool]
        /// </summary>
        DECRYPT = 0x00000105,

        /// <summary>
        /// True if key supports wrapping (i.e., can be used to wrap other keys) [bool]
        /// </summary>
        WRAP = 0x00000106,

        /// <summary>
        /// True if key supports unwrapping (i.e., can be used to unwrap other keys) [bool]
        /// </summary>
        UNWRAP = 0x00000107,

        /// <summary>
        /// True if key supports signatures (i.e., authentication codes) where the signature is an appendix to the data [bool]
        /// </summary>
        SIGN = 0x00000108,

        /// <summary>
        /// True if key supports signatures where the data can be recovered from the signature [bool]
        /// </summary>
        SIGN_RECOVER = 0x00000109,

        /// <summary>
        /// True if key supports verification (i.e., of authentication codes) where the signature is an appendix to the data [bool]
        /// </summary>
        VERIFY = 0x0000010A,

        /// <summary>
        /// True if key supports verification where the data is recovered from the signature [bool]
        /// </summary>
        VERIFY_RECOVER = 0x0000010B,

        /// <summary>
        /// True if key supports key derivation (i.e., if other keys can be derived from this one) [bool]
        /// </summary>
        DERIVE = 0x0000010C,

        /// <summary>
        /// Start date for the certificate/key [DateTime]
        /// </summary>
        START_DATE = 0x00000110,

        /// <summary>
        /// End date for the certificate/key [DateTime]
        /// </summary>
        END_DATE = 0x00000111,

        /// <summary>
        /// Modulus n [byte array]
        /// </summary>
        MODULUS = 0x00000120,

        /// <summary>
        /// Length in bits of modulus n [uint]
        /// </summary>
        MODULUS_BITS = 0x00000121,

        /// <summary>
        /// Public exponent e [byte array]
        /// </summary>
        PUBLIC_EXPONENT = 0x00000122,

        /// <summary>
        /// Private exponent d [byte array]
        /// </summary>
        PRIVATE_EXPONENT = 0x00000123,

        /// <summary>
        /// Prime p [byte array]
        /// </summary>
        PRIME_1 = 0x00000124,

        /// <summary>
        /// Prime q [byte array]
        /// </summary>
        PRIME_2 = 0x00000125,

        /// <summary>
        /// Private exponent d modulo p-1 [byte array]
        /// </summary>
        EXPONENT_1 = 0x00000126,

        /// <summary>
        /// Private exponent d modulo q-1 [byte array]
        /// </summary>
        EXPONENT_2 = 0x00000127,

        /// <summary>
        /// CRT coefficient q^-1 mod p [byte array]
        /// </summary>
        COEFFICIENT = 0x00000128,

        /// <summary>
        /// DER-encoding of the SubjectPublicKeyInfo [byte array]
        /// </summary>
        PUBLIC_KEY_INFO = 0x00000129,

        /// <summary>
        /// Prime p (512 to 1024 bits, in steps of 64 bits) [byte array]
        /// </summary>
        PRIME = 0x00000130,

        /// <summary>
        /// Subprime q (160 bits) [byte array]
        /// </summary>
        SUBPRIME = 0x00000131,

        /// <summary>
        /// Base g [byte array]
        /// </summary>
        BASE = 0x00000132,

        /// <summary>
        /// Length of the prime value [uint]
        /// </summary>
        PRIME_BITS = 0x00000133,

        /// <summary>
        /// Length of the subprime value [uint]
        /// </summary>
        SUBPRIME_BITS = 0x00000134,

        /// <summary>
        /// Length in bits of private value x [uint]
        /// </summary>
        VALUE_BITS = 0x00000160,

        /// <summary>
        /// Length in bytes of key value [uint]
        /// </summary>
        VALUE_LEN = 0x00000161,

        /// <summary>
        /// True if key is extractable and can be wrapped [bool]
        /// </summary>
        EXTRACTABLE = 0x00000162,

        /// <summary>
        /// True only if key was either generated locally (i.e., on the token) or created as a copy of a key 
        /// which had its CKA_LOCAL attribute set to true [bool]
        /// </summary>
        LOCAL = 0x00000163,

        /// <summary>
        /// True if key has never had the CKA_EXTRACTABLE attribute set to true [bool]
        /// </summary>
        NEVER_EXTRACTABLE = 0x00000164,

        /// <summary>
        /// True if key has always had the CKA_SENSITIVE attribute set to true [bool]
        /// </summary>
        ALWAYS_SENSITIVE = 0x00000165,

        /// <summary>
        /// Identifier of the mechanism used to generate the key material [CKM/uint]
        /// </summary>
        KEY_GEN_MECHANISM = 0x00000166,

        /// <summary>
        /// True if object can be modified [bool]
        /// </summary>
        MODIFIABLE = 0x00000170,

        /// <summary>
        /// True if object can be copied [bool]
        /// </summary>
        COPYABLE = 0x00000171,

        /// <summary>
        /// True if object can be destroyed [bool]
        /// </summary>
        DESTROYABLE = 0x00000172,

        /// <summary>
        /// DER-encoding of an ANSI X9.62 Parameters value [byte array]
        /// </summary>
        ECDSA_PARAMS = 0x00000180,

        /// <summary>
        /// DER-encoding of an ANSI X9.62 Parameters value [byte array]
        /// </summary>
        EC_PARAMS = 0x00000180,

        /// <summary>
        /// DER-encoding of ANSI X9.62 ECPoint value Q [byte array]
        /// </summary>
        EC_POINT = 0x00000181,

        /// <summary>
        /// True if the key requires a secondary authentication to take place before its use it allowed [bool]
        /// </summary>
        SECONDARY_AUTH = 0x00000200,

        /// <summary>
        /// Mask indicating the current state of the secondary authentication PIN [uint]
        /// </summary>
        AUTH_PIN_FLAGS = 0x00000201,

        /// <summary>
        /// If true, the user has to supply the PIN for each use (sign or decrypt) with the key [bool]
        /// </summary>
        ALWAYS_AUTHENTICATE = 0x00000202,

        /// <summary>
        /// True if the key can only be wrapped with a wrapping key that has CKA_TRUSTED set to true [bool]
        /// </summary>
        WRAP_WITH_TRUSTED = 0x00000210,

        /// <summary>
        /// The attribute template to match against any keys wrapped using this wrapping key. 
        /// Keys that do not match cannot be wrapped. [List of ObjectAttribute / CK_ATTRIBUTE array]
        /// </summary>
        WRAP_TEMPLATE = (ARRAY_ATTRIBUTE | 0x00000211),

        /// <summary>
        /// The attribute template to apply to any keys unwrapped using this wrapping key. 
        /// Any user supplied template is applied after this template as if the object has already been created.
        /// [List of ObjectAttribute / CK_ATTRIBUTE array]
        /// </summary>
        UNWRAP_TEMPLATE = (ARRAY_ATTRIBUTE | 0x00000212),

        /// <summary>
        /// The attribute template to apply to any keys derived using this key.
        /// Any user supplied template is applied after this template as if the object has already been created. 
        /// [List of ObjectAttribute / CK_ATTRIBUTE array]
        /// </summary>
        DERIVE_TEMPLATE = (ARRAY_ATTRIBUTE | 0x00000213),

        /// <summary>
        /// Format of OTP values produced with this key: 
        /// CK_OTP_FORMAT_DECIMAL = Decimal,
        /// CK_OTP_FORMAT_HEXADECIMAL = Hexadecimal, 
        /// CK_OTP_FORMAT_ALPHANUMERIC = Alphanumeric, 
        /// CK_OTP_FORMAT_BINARY = Only binary values [uint]
        /// </summary>
        OTP_FORMAT = 0x00000220,

        /// <summary>
        /// Default length of OTP values (in the CKA_OTP_FORMAT) produced with this key [uint]
        /// </summary>
        OTP_LENGTH = 0x00000221,

        /// <summary>
        /// Interval between OTP values produced with this key, in seconds. [uint]
        /// </summary>
        OTP_TIME_INTERVAL = 0x00000222,

        /// <summary>
        /// Set to true when the token is capable of returning OTPs suitable for human consumption [bool]
        /// </summary>
        OTP_USER_FRIENDLY_MODE = 0x00000223,

        /// <summary>
        /// Parameter requirements when generating or verifying OTP values with this key: 
        /// CK_OTP_PARAM_MANDATORY = A challenge must be supplied. CK_OTP_PARAM_OPTIONAL = A challenge may be supplied but need not be. 
        /// CK_OTP_PARAM_IGNORED = A challenge, if supplied, will be ignored. [uint]
        /// </summary>
        OTP_CHALLENGE_REQUIREMENT = 0x00000224,

        /// <summary>
        /// Parameter requirements when generating or verifying OTP values with this key: 
        /// CK_OTP_PARAM_MANDATORY = A time value must be supplied. CK_OTP_PARAM_OPTIONAL = A time value may be supplied but need not be. 
        /// CK_OTP_PARAM_IGNORED = A time value, if supplied, will be ignored. [uint]
        /// </summary>
        OTP_TIME_REQUIREMENT = 0x00000225,

        /// <summary>
        /// Parameter requirements when generating or verifying OTP values with this key: 
        /// CK_OTP_PARAM_MANDATORY = A counter value must be supplied. CK_OTP_PARAM_OPTIONAL = A counter value may be supplied but need not be.
        /// CK_OTP_PARAM_IGNORED = A counter value, if supplied, will be ignored. [uint]
        /// </summary>
        OTP_COUNTER_REQUIREMENT = 0x00000226,

        /// <summary>
        /// Parameter requirements when generating or verifying OTP values with this key: 
        /// CK_OTP_PARAM_MANDATORY = A PIN value must be supplied. CK_OTP_PARAM_OPTIONAL = A PIN value may be supplied but need not be.
        /// CK_OTP_PARAM_IGNORED = A PIN value, if supplied, will be ignored. [uint]
        /// </summary>
        OTP_PIN_REQUIREMENT = 0x00000227,

        /// <summary>
        /// Value of the associated internal counter [byte array]
        /// </summary>
        OTP_COUNTER = 0x0000022E,

        /// <summary>
        /// Value of the associated internal UTC time in the form YYYYMMDDhhmmss [string]
        /// </summary>
        OTP_TIME = 0x0000022F,

        /// <summary>
        /// Text string that identifies a user associated with the OTP key (may be used to enhance the user experience). [string]
        /// </summary>
        OTP_USER_IDENTIFIER = 0x0000022A,

        /// <summary>
        /// Text string that identifies a service that may validate OTPs generated by this key [string]
        /// </summary>
        OTP_SERVICE_IDENTIFIER = 0x0000022B,

        /// <summary>
        /// Logotype image that identifies a service that may validate OTPs generated by this key. [byte array]
        /// </summary>
        OTP_SERVICE_LOGO = 0x0000022C,

        /// <summary>
        /// MIME type of the CKA_OTP_SERVICE_LOGO attribute value [string]
        /// </summary>
        OTP_SERVICE_LOGO_TYPE = 0x0000022D,

        /// <summary>
        /// DER-encoding of the object identifier indicating the data object type of GOST R 34.10-2001. [byte array]
        /// </summary>
        GOSTR3410_PARAMS = 0x00000250,

        /// <summary>
        /// DER-encoding of the object identifier indicating the data object type of GOST R 34.11-94. [byte array]
        /// </summary>
        GOSTR3411_PARAMS = 0x00000251,

        /// <summary>
        /// DER-encoding of the object identifier indicating the data object type of GOST 28147-89. [byte array]
        /// </summary>
        GOST28147_PARAMS = 0x00000252,

        /// <summary>
        /// Hardware feature (type) [CKH/uint]
        /// </summary>
        HW_FEATURE_TYPE = 0x00000300,

        /// <summary>
        /// The value of the counter will reset to a previously returned value if the token is initialized [bool]
        /// </summary>
        RESET_ON_INIT = 0x00000301,

        /// <summary>
        /// The value of the counter has been reset at least once at some point in time [bool]
        /// </summary>
        HAS_RESET = 0x00000302,

        /// <summary>
        /// Screen resolution (in pixels) in X-axis [uint]
        /// </summary>
        PIXEL_X = 0x00000400,

        /// <summary>
        /// Screen resolution (in pixels) in Y-axis [uint]
        /// </summary>
        PIXEL_Y = 0x00000401,

        /// <summary>
        /// DPI, pixels per inch [uint]
        /// </summary>
        RESOLUTION = 0x00000402,

        /// <summary>
        /// Number of character rows for character-oriented displays [uint]
        /// </summary>
        CHAR_ROWS = 0x00000403,

        /// <summary>
        /// Number of character columns for character-oriented displays [uint]
        /// </summary>
        CHAR_COLUMNS = 0x00000404,

        /// <summary>
        /// Color support [bool]
        /// </summary>
        COLOR = 0x00000405,

        /// <summary>
        /// The number of bits of color or grayscale information per pixel. [uint]
        /// </summary>
        BITS_PER_PIXEL = 0x00000406,

        /// <summary>
        /// String indicating supported character sets, as defined by IANA MIBenum sets (www.iana.org). 
        /// Supported character sets are separated with ";" e.g. a token supporting iso-8859-1 and us-ascii would
        /// set the attribute value to "4;3". [string]
        /// </summary>
        CHAR_SETS = 0x00000480,

        /// <summary>
        /// String indicating supported content transfer encoding methods, as defined by IANA (www.iana.org). 
        /// Supported methods are separated with ";" e.g. a token supporting 7bit, 8bit and base64 could set the
        /// attribute value to "7bit;8bit;base64". [string]
        /// </summary>
        ENCODING_METHODS = 0x00000481,

        /// <summary>
        /// String indicating supported (presentable) MIME-types, as defined by IANA (www.iana.org). 
        /// Supported types are separated with ";" e.g. a token supporting MIME types "a/b", "a/c" and "a/d" would
        /// set the attribute value to "a/b;a/c;a/d". [string]
        /// </summary>
        MIME_TYPES = 0x00000482,

        /// <summary>
        /// The type of mechanism object [CKM/uint]
        /// </summary>
        MECHANISM_TYPE = 0x00000500,

        /// <summary>
        /// Attributes the token always will include in the set of CMS signed attributes [byte array]
        /// </summary>
        REQUIRED_CMS_ATTRIBUTES = 0x00000501,

        /// <summary>
        /// Attributes the token will include in the set of CMS signed attributes in the absence of any
        /// attributes specified by the application [byte array]
        /// </summary>
        DEFAULT_CMS_ATTRIBUTES = 0x00000502,

        /// <summary>
        /// Attributes the token may include in the set of CMS signed attributes upon request by the application [byte array]
        /// </summary>
        SUPPORTED_CMS_ATTRIBUTES = 0x00000503,

        /// <summary>
        /// A list of mechanisms allowed to be used with this key [List of CKM / List of uint / CKM array / uint array]
        /// </summary>
        ALLOWED_MECHANISMS = (ARRAY_ATTRIBUTE | 0x00000600),

        /// <summary>
        /// Permanently reserved for token vendors
        /// </summary>
        VENDOR_DEFINED = 0x80000000
    }
}
