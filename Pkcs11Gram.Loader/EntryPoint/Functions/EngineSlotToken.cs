// Project: Pkcs11Gram.Loader
// File: EngineSlotToken.cs
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
using Pkcs11Gram.Core.Exception;
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Slot;
using Pkcs11Gram.Loader.Runtime;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Loader.EntryPoint
{
    internal partial class Engine
    {
        public Rv C_GetSlotList(byte tokenPresent, IntPtr pSlotList, IntPtr pulCount)
        {
            if (!App.IsInitialized)
                return Rv.CRYPTOKI_NOT_INITIALIZED;

            if (pulCount == IntPtr.Zero)
                return Rv.ARGUMENTS_BAD;

            if (pSlotList == IntPtr.Zero)
            {
                Marshal.StructureToPtr(
                    App.Slots.Count,
                    pulCount,
                    false);
            }
            else
            {
                if (App.Slots.Count > Marshal.PtrToStructure<UInt32>(pulCount))
                    return Rv.BUFFER_TOO_SMALL;

                UInt32[] list = UnmanagedArray.PtrToStructureArray<UInt32, UInt32>(pSlotList, pulCount);

                int i = 0;
                foreach (var item in App.Slots)
                {
                    list[i] = item.Key;
                    i++;
                }
                UnmanagedArray.StructureArrayToPtr(list, pSlotList);
            }

            return Rv.OK;
        }

        public Rv C_GetSlotInfo(UInt32 slotID, ref SlotInfo pInfo)
        {
            if (!App.IsInitialized)
                return Rv.CRYPTOKI_NOT_INITIALIZED;

            ISlot slot = GetSlot(slotID);

            pInfo = slot.GetSlotInfo().Result;

            return Rv.OK;
        }

        public Rv C_GetTokenInfo(UInt32 slotID, ref TokenInfo pInfo)
        {
            if (!App.IsInitialized)
                return Rv.CRYPTOKI_NOT_INITIALIZED;

            IToken token = GetToken(slotID);

            pInfo = token.GetTokenInfo().Result;

            return Rv.OK;
        }

        public Rv C_WaitForSlotEvent(SlotFlags flags, ref UInt32 pSlot, ref IntPtr pReserved)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_GetMechanismList(UInt32 slotID, ref MechanismType pMechanismList, ref UInt32 pulCount)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_GetMechanismInfo(UInt32 slotID, MechanismType type, ref MechanismInfo pInfo)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_InitToken(UInt32 slotID, IntPtr pPin, UInt32 ulPinLen, IntPtr pLabel)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_InitPIN(UInt32 hSession, IntPtr pPin, UInt32 ulPinLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_SetPIN(UInt32 hSession, IntPtr pOldPin, UInt32 ulOldLen, IntPtr pNewPin, UInt32 ulNewLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
