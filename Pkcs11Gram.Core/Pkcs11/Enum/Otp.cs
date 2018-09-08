// Project: Pkcs11Gram.Core
// File: Otp.cs
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
    /// CK_OTP
    /// </summary>
    public enum Otp : UInt32
    {
        /// <summary>
        /// An actual OTP value
        /// </summary>
        VALUE = 0,

        /// <summary>
        /// A UTF8 string containing a PIN for use when computing or verifying PIN-based OTP values
        /// </summary>
        PIN = 1,

        /// <summary>
        /// Challenge to use when computing or verifying challenge-based OTP values
        /// </summary>
        CHALLENGE = 2,

        /// <summary>
        /// UTC time value in the form YYYYMMDDhhmmss to use when computing or verifying time-based OTP values
        /// </summary>
        TIME = 3,

        /// <summary>
        /// Counter value to use when computing or verifying counter-based OTP values
        /// </summary>
        COUNTER = 4,

        /// <summary>
        /// Bit flags indicating the characteristics of the sought OTP as defined below
        /// </summary>
        FLAGS = 5,

        /// <summary>
        /// Desired output length (overrides any default value)
        /// </summary>
        OUTPUT_LENGTH = 6,

        /// <summary>
        /// Returned OTP format
        /// </summary>
        OUTPUT_FORMAT = 7,
    }
}
