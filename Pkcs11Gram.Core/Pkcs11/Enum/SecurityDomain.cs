// Project: Pkcs11Gram.Core
// File: SecurityDomain.cs
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
    /// CK_SECURITY_DOMAIN
    /// </summary>
    public enum SecurityDomain : UInt32
    {
        /// <summary>
        /// No JAVA MIDP security domain specified
        /// </summary>
        UNSPECIFIED = 0,

        /// <summary>
        /// Manufacturer protection JAVA MIDP security domain
        /// </summary>
        MANUFACTURER = 1,

        /// <summary>
        /// Operator protection JAVA MIDP security domain
        /// </summary>
        OPERATOR = 2,

        /// <summary>
        /// Third party protection JAVA MIDP security domain
        /// </summary>
        THIRD_PARTY = 3,
    }
}
