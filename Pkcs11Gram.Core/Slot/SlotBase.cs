// Project: Pkcs11Gram.Core
// File: SlotBase.cs
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
using Castle.MicroKernel;
using Pkcs11Gram.Core.Pkcs11;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Slot
{
    public abstract class SlotBase<TToken, TSession> : ISlot
        where TToken : TokenBase<TSession>, IToken
        where TSession : SessionBase, ISession
    {
        /// <summary>
        /// Slot Id
        /// </summary>
        public uint SlotId { get; set; }

        /// <summary>
        /// Slot Description
        /// 64 bytes.
        /// </summary>
        public string SlotDescription { get; private set; } = string.Empty;

        /// <summary>
        /// Manufacturer Id
        /// 32 bytes.
        /// </summary>
        public string ManufacturerId { get; private set; } = string.Empty;

        /// <summary>
        /// Hardware Version
        /// </summary>
        public (byte, byte) HardwareVersion { get; protected set; } = (0, 0);

        /// <summary>
        /// Firmware Version
        /// </summary>
        public (byte, byte) FirmwareVersion { get; protected set; } = (0, 0);

        /// <summary>
        /// Token is in slot
        /// </summary>
        public bool HasToken { get; protected set; }

        /// <summary>
        /// Device Removeable
        /// </summary>
        public bool IsRemoveable { get; protected set; }

        /// <summary>
        /// Slot is hardware slot.
        /// </summary>
        public bool IsHardware { get; protected set; }

        private readonly IKernel Kernel;

        public SlotBase(
            IKernel kernel,
            string slotDescription,
            string manufacturerId)
        {
            Kernel = kernel;
            if (slotDescription.Length > 60)
                slotDescription = slotDescription.Substring(0, 60);

            if (manufacturerId.Length > 32)
                manufacturerId = manufacturerId.Substring(0, 32);

            SlotDescription = slotDescription;
            ManufacturerId = manufacturerId;
        }

        /// <summary>
        /// Get pkcs11 slot info
        /// </summary>
        /// <returns></returns>
        public virtual Task<SlotInfo> GetSlotInfo()
        {
            string slotId = SlotId.ToString().PadLeft(2, '0');
            if (slotId.Length > 2)
                slotId.Substring(0, 2);
            string slotDescription = $"#{slotId} {SlotDescription}";

            SlotFlags slotFlags = SlotFlags.NONE;

            if (IsRemoveable)
                slotFlags = slotFlags | SlotFlags.REMOVABLE_DEVICE;

            if (IsHardware)
                slotFlags = slotFlags | SlotFlags.HW_SLOT;

            if (HasToken)
                slotFlags = slotFlags | SlotFlags.TOKEN_PRESENT;

            return Task.FromResult(new SlotInfo()
            {
                SlotDescription = Encoding.ASCII.GetBytes(slotDescription.PadRight(64)),
                ManufacturerId = Encoding.ASCII.GetBytes(ManufacturerId.PadRight(32)),
                HardwareVersion = new Pkcs11Version() { Major = HardwareVersion.Item1, Minor = HardwareVersion.Item2 },
                FirmwareVersion = new Pkcs11Version() { Major = FirmwareVersion.Item1, Minor = FirmwareVersion.Item2 },
                Flags = slotFlags,
            });
        }

        /// <summary>
        /// Get slot token
        /// </summary>
        /// <returns></returns>
        public async Task<IToken> GetToken()
        {
            return await ProcessToken(Kernel.Resolve<TToken>());
        }

        protected abstract Task<IToken> ProcessToken(TToken token);
    }
}
