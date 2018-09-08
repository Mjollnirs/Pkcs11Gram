// Project: Pkcs11Gram.Core
// File: Pkcs5Pbkdf2SlatSourceType.cs
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
    /// CK_PKCS5_PBKDF2_SALT_SOURCE_TYPE is used to indicate the
    /// source of the salt value when deriving a key using PKCS #5
    /// PBKDF2.
    /// </summary>
    public enum Pkcs5Pbkdf2SlatSourceType : UInt32
    {
        /// <summary>
        /// PKCS #5 PBKDF2 Key Generation: Salt specified
        /// </summary>
        SALT_SPECIFIED = 0x00000001,
    }
}
