﻿// Project: Pkcs11Gram.Core
// File: Notification.cs
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
    /// CK_NOTIFICATION
    /// Notifications
    /// </summary>
    public enum Notification : UInt32
    {
        /// <summary>
        /// Cryptoki is surrendering the execution of a function executing in a session so that the application may perform other operations
        /// </summary>
        CKN_SURRENDER = 0,

        /// <summary>
        /// Cryptoki is informing the application that the OTP for a key on a connected token just changed
        /// </summary>
        CKN_OTP_CHANGED = 1
    }
}