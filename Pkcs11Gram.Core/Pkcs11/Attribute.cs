// Project: Pkcs11Gram.Core
// File: Attribute.cs
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
    /// CK_ATTRIBUTE
    /// Defines the type, value, and length of an attribute
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct Attribute
    {
        /// <summary>
        /// The attribute type
        /// </summary>
        public AttributeType type;

        /// <summary>
        /// Pointer to the value of the attribute
        /// </summary>
        public IntPtr value;

        /// <summary>
        /// Length in bytes of the value
        /// </summary>
        public UInt32 valueLen;
    }
}
