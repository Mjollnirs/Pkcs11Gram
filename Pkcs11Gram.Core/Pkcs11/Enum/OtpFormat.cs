// Project: Pkcs11Gram.Core
// File: OtpFormat.cs
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
    /// CK_OTP_FORMAT
    /// </summary>
    public enum OtpFormat : UInt32
    {
        /// <summary>
        /// Decimal (default) (UTF8-encoded) format of OTP value
        /// </summary>
        DECIMAL = 0,

        /// <summary>
        /// Hexadecimal (UTF8-encoded) format of OTP value
        /// </summary>
        HEXADECIMAL = 1,

        /// <summary>
        /// Alphanumeric (UTF8-encoded) format of OTP value
        /// </summary>
        ALPHANUMERIC = 2,

        /// <summary>
        /// Binary format of OTP value
        /// </summary>
        BINARY = 3,
    }
}
