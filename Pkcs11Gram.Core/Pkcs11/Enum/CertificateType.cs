// Project: Pkcs11Gram.Core
// File: CertificateType.cs
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
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_CERTIFICATE_TYPE
    /// </summary>
    public enum CertificateType : UInt32
    {
        /// <summary>
        /// X.509 public key certificate
        /// </summary>
        X_509 = 0x00000000,

        /// <summary>
        /// X.509 attribute certificate
        /// </summary>
        X_509_ATTR_CERT = 0x00000001,

        /// <summary>
        /// WTLS public key certificate
        /// </summary>
        WTLS = 0x00000002,

        /// <summary>
        /// Permanently reserved for token vendors
        /// </summary>
        VENDOR_DEFINED = 0x80000000
    }
}
