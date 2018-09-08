// Project: Pkcs11Gram.Core
// File: HwFeatureType.cs
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
    /// CK_HW_FEATURE_TYPE
    /// Hardware feature types
    /// </summary>
    public enum HwFeatureType : UInt32
    {
        /// <summary>
        /// Monotonic counter objects represent hardware counters that exist on the device.
        /// </summary>
        MONOTONIC_COUNTER = 0x00000001,

        /// <summary>
        /// Clock objects represent real-time clocks that exist on the device.
        /// </summary>
        CLOCK = 0x00000002,

        /// <summary>
        /// User interface objects represent the presentation capabilities of the device.
        /// </summary>
        USER_INTERFACE = 0x00000003,

        /// <summary>
        /// Permanently reserved for token vendors.
        /// </summary>
        VENDOR_DEFINED = 0x80000000
    }
}
