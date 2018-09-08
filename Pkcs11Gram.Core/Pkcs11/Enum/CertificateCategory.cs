// Project: Pkcs11Gram.Core
// File: CertificateCategory.cs
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
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_CERTIFICATE_CATEGORY
    /// </summary>
    public enum CertificateCategory : UInt32
    {
        /// <summary>
        /// No certificate category specified
        /// </summary>
        UNSPECIFIED = 0,

        /// <summary>
        /// Certificate belongs to owner of the token
        /// </summary>
        TOKEN_USER = 1,

        /// <summary>
        /// Certificate belongs to a certificate authority
        /// </summary>
        AUTHORITY = 2,

        /// <summary>
        /// Certificate belongs to an end entity (i.e. not a CA)
        /// </summary>
        OTHER_ENTITY = 3,
    }
}
