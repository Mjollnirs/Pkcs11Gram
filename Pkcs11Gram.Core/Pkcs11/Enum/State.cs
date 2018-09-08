// Project: Pkcs11Gram.Core
// File: State.cs
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
    /// CK_STATE
    /// Session States
    /// </summary>
    public enum State : UInt32
    {
        /// <summary>
        /// The application has opened a read-only session. 
        /// The application has read-only access to public token objects 
        /// and read/write access to public session objects.
        /// </summary>
        RO_PUBLIC_SESSION = 0,

        /// <summary>
        /// The normal user has been authenticated to the token. 
        /// The application has read-only access to all token objects (public or private)
        /// and read/write access to all session objects (public or private).
        /// </summary>
        RO_USER_FUNCTIONS = 1,

        /// <summary>
        /// The application has opened a read/write session. 
        /// The application has read/write access to all public objects.
        /// </summary>
        RW_PUBLIC_SESSION = 2,

        /// <summary>
        /// The normal user has been authenticated to the token. 
        /// The application has read/write access to all objects.
        /// </summary>
        RW_USER_FUNCTIONS = 3,

        /// <summary>
        /// The Security Officer has been authenticated to the token.
        /// The application has read/write access only to public objects on the token,
        /// not to private objects. The SO can set the normal user's PIN.
        /// </summary>
        RW_SO_FUNCTIONS = 4
    }
}
