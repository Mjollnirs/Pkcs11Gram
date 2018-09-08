// Project: Pkcs11Gram.Core
// File: TokenFlags.cs
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
    /// CK_TOKEN_FLAGS
    /// </summary>
    [Flags]
    public enum TokenFlags : UInt32
    {
        /// <summary>
        /// Defalut Value
        /// </summary>
        NONE = 0x00000000,

        /// <summary>
        /// True if the token has its own random number generator
        /// </summary>
        RNG = 0x00000001,

        /// <summary>
        /// True if the token is write-protected
        /// </summary>
        WRITE_PROTECTED = 0x00000002,

        /// <summary>
        /// True if there are some cryptographic functions that a user must be logged in to perform
        /// </summary>
        LOGIN_REQUIRED = 0x00000004,

        /// <summary>
        /// True if the normal user's PIN has been initialized
        /// </summary>
        USER_PIN_INITIALIZED = 0x00000008,

        /// <summary>
        /// True if a successful save of a session's cryptographic operations state always contains all keys needed to restore the state of the session
        /// </summary>
        RESTORE_KEY_NOT_NEEDED = 0x00000020,

        /// <summary>
        /// True if token has its own hardware clock
        /// </summary>
        CLOCK_ON_TOKEN = 0x00000040,

        /// <summary>
        /// True if token has a "protected authentication path", whereby a user can log into the token without passing a PIN through the Cryptoki library
        /// </summary>
        PROTECTED_AUTHENTICATION_PATH = 0x00000100,

        /// <summary>
        /// True if a single session with the token can perform dual cryptographic operations
        /// </summary>
        DUAL_CRYPTO_OPERATIONS = 0x00000200,

        /// <summary>
        /// True if the token has been initialized using C_InitializeToken or an equivalent mechanism outside the scope of this standard. Calling C_InitializeToken when this flag is set will cause the token to be reinitialized.
        /// </summary>
        TOKEN_INITIALIZED = 0x00000400,

        /// <summary>
        /// True if the token supports secondary authentication for private key objects.
        /// </summary>
        SECONDARY_AUTHENTICATION = 0x00000800,

        /// <summary>
        /// True if an incorrect user login PIN has been entered at least once since the last successful authentication.
        /// </summary>
        USER_PIN_COUNT_LOW = 0x00010000,

        /// <summary>
        /// True if supplying an incorrect user PIN will it to become locked.
        /// </summary>
        USER_PIN_FINAL_TRY = 0x00020000,

        /// <summary>
        /// True if the user PIN has been locked. User login to the token is not possible.
        /// </summary>
        USER_PIN_LOCKED = 0x00040000,

        /// <summary>
        /// True if the user PIN value is the default value set by token initialization or manufacturing, or the PIN has been expired by the card.
        /// </summary>
        USER_PIN_TO_BE_CHANGED = 0x00080000,

        /// <summary>
        /// True if an incorrect SO login PIN has been entered at least once since the last successful authentication.
        /// </summary>
        SO_PIN_COUNT_LOW = 0x00100000,

        /// <summary>
        /// True if supplying an incorrect SO PIN will it to become locked.
        /// </summary>
        SO_PIN_FINAL_TRY = 0x00200000,

        /// <summary>
        /// True if the SO PIN has been locked. User login to the token is not possible.
        /// </summary>
        SO_PIN_LOCKED = 0x00400000,

        /// <summary>
        /// True if the SO PIN value is the default value set by token initialization or manufacturing, or the PIN has been expired by the card.
        /// </summary>
        SO_PIN_TO_BE_CHANGED = 0x00800000,

        /// <summary>
        /// True if the token failed a FIPS 140-2 self-test and entered an error state.
        /// </summary>
        ERROR_STATE = 0x01000000,
    }
}
