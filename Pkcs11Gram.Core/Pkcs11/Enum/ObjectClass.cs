// Project: Pkcs11Gram.Core
// File: ObjectClass.cs
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
    /// CK_OBJECT_CLASS
    /// Object class
    /// </summary>
    public enum ObjectClass : UInt32
    {
        /// <summary>
        /// Data object that holds information defined by an application.
        /// </summary>
        DATA = 0x00000000,

        /// <summary>
        /// Certificate object that holds public-key or attribute certificates.
        /// </summary>
        CERTIFICATE = 0x00000001,

        /// <summary>
        /// Public key object that holds public keys.
        /// </summary>
        PUBLIC_KEY = 0x00000002,

        /// <summary>
        /// Private key object that holds private keys.
        /// </summary>
        PRIVATE_KEY = 0x00000003,

        /// <summary>
        /// Secret key object that holds secret keys.
        /// </summary>
        SECRET_KEY = 0x00000004,

        /// <summary>
        /// Hardware feature object that represent features of the device.
        /// </summary>
        HW_FEATURE = 0x00000005,

        /// <summary>
        /// Domain parameter object that holds public domain parameters.
        /// </summary>
        DOMAIN_PARAMETERS = 0x00000006,

        /// <summary>
        /// Mechanism object that provides information about mechanisms supported by a device beyond that given by the CK_MECHANISM_INFO structure.
        /// </summary>
        MECHANISM = 0x00000007,

        /// <summary>
        /// OTP key object that holds secret keys used by OTP tokens.
        /// </summary>
        OTP_KEY = 0x00000008,

        /// <summary>
        /// Reserved for token vendors.
        /// </summary>
        VENDOR_DEFINED = 0x80000000
    }
}
