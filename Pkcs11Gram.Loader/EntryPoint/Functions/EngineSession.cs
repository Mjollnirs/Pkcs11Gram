// Project: Pkcs11Gram.Loader
// File: EngineSession.cs
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
using System;
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Loader.EntryPoint
{
    internal partial class Engine
    {
        public Rv C_OpenSession(UInt32 slotID, SlotFlags flags, IntPtr pApplication, Notify Notify, IntPtr phSession)
        {
            if (phSession == IntPtr.Zero)
                return Rv.ARGUMENTS_BAD;

            try
            {
                IToken token = GetToken(slotID);

                token.OpenSession();
            }
            catch (Pkcs11Exception ex)
            {
                return ex.Pkcs11Rv;
            }

            return Rv.OK;
        }

        public Rv C_CloseSession(UInt32 hSession)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_CloseAllSessions(UInt32 slotID)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_GetSessionInfo(UInt32 hSession, ref SessionInfo pInfo)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_GetOperationState(UInt32 hSession, IntPtr pOperationState, ref UInt32 pulOperationStateLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_SetOperationState(UInt32 hSession, IntPtr pOperationState, UInt32 ulOperationStateLen, UInt32 hEncryptionKey, UInt32 hAuthenticationKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_Login(UInt32 hSession, UserType userType, IntPtr pPin, UInt32 ulPinLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_Logout(UInt32 hSession)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
