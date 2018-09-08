﻿// Project: Pkcs11Gram.Core
// File: Mechanism.cs
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
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_MECHANISM
    /// Specifies a particular mechanism and any parameters it requires
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct Mechanism
    {
        /// <summary>
        /// The type of mechanism
        /// </summary>
        public MechanismType MechanismType;

        /// <summary>
        /// Pointer to the parameter if required by the mechanism
        /// </summary>
        public IntPtr Parameter;

        /// <summary>
        /// Length of the parameter in bytes
        /// </summary>
        public UInt32 ParameterLen;
    }
}
