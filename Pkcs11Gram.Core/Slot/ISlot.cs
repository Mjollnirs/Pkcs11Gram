// Project: Pkcs11Gram.Core
// File: ISlot.cs
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
using Pkcs11Gram.Core.Pkcs11;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Slot
{
    public interface ISlot : IBase
    {
        /// <summary>
        /// Slot Id
        /// </summary>
        UInt32 SlotId { get; }

        /// <summary>
        /// Slot Description
        /// 64 bytes.
        /// </summary>
        string SlotDescription { get; }

        /// <summary>
        /// Manufacturer Id
        /// 32 bytes.
        /// </summary>
        string ManufacturerId { get; }

        /// <summary>
        /// Token is in slot
        /// </summary>
        bool HasToken { get; }

        /// <summary>
        /// Device Removeable
        /// </summary>
        bool IsRemoveable { get; }

        /// <summary>
        /// Slot is hardware slot.
        /// </summary>
        bool IsHardware { get; }

        /// <summary>
        /// Hardware Version
        /// </summary>
        (byte, byte) HardwareVersion { get; }

        /// <summary>
        /// Firmware Version
        /// </summary>
        (byte, byte) FirmwareVersion { get; }

        /// <summary>
        /// Get pcks11 slot info
        /// </summary>
        /// <returns></returns>
        Task<SlotInfo> GetSlotInfo();

        /// <summary>
        /// Get slot token
        /// </summary>
        /// <returns></returns>
        Task<IToken> GetToken();
    }
}
