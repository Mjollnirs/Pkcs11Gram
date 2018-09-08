// Project: Pkcs11Gram.Core
// File: RsaPkcsOaepSourceType.cs
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
using System;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_RSA_PKCS_OAEP_SOURCE_TYPE  is used to indicate the source
    /// of the encoding parameter when formatting a message block
    /// for the PKCS #1 OAEP encryption scheme.
    /// </summary>
    public enum RsaPkcsOaepSourceType : UInt32
    {
        /// <summary>
        /// PKCS #1 RSA OAEP: Encoding parameter specified
        /// </summary>
        DATA_SPECIFIED = 0x00000001,
    }
}
