// Project: Pkcs11Gram.Core
// File: OtpParam.cs
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
    /// CK_OTP_PARAM
    /// </summary>
    public enum OtpParam : UInt32
    {
        /// <summary>
        /// OTP parameter, if supplied, will be ignored
        /// </summary>
        IGNORED = 0,

        /// <summary>
        /// OTP parameter may be supplied but need not be
        /// </summary>
        OPTIONAL = 1,

        /// <summary>
        /// OTP parameter must be supplied
        /// </summary>
        MANDATORY = 2,
    }
}
