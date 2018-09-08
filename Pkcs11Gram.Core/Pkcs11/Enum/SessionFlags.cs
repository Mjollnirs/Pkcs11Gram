﻿// Project: Pkcs11Gram.Core
// File: SessionFlags.cs
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
    /// CK_SESSION_FLAGS
    /// </summary>
    [Flags]
    public enum SessionFlags
    {
        /// <summary>
        /// True if the session is read/write, false if the session is read-only
        /// </summary>
        RW_SESSION = 0x00000002,

        /// <summary>
        /// This flag is provided for backward compatibility, and should always be set to true
        /// </summary>
        SERIAL_SESSION = 0x00000004,
    }
}
