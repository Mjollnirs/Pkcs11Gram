// Project: Pkcs11Gram.Loader
// File: EngineVerify.cs
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

namespace Pkcs11Gram.Loader.EntryPoint
{
    public static partial class Engine
    {
        public static Rv C_VerifyInit(UInt32 hSession, ref Mechanism pMechanism, UInt32 hKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_Verify(UInt32 hSession, IntPtr pData, UInt32 ulDataLen, IntPtr pSignature, UInt32 ulSignatureLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_VerifyUpdate(UInt32 hSession, IntPtr pPart, UInt32 ulPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_VerifyFinal(UInt32 hSession, IntPtr pSignature, UInt32 ulSignatureLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_VerifyRecoverInit(UInt32 hSession, ref Mechanism pMechanism, UInt32 hKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_VerifyRecover(UInt32 hSession, IntPtr pSignature, UInt32 ulSignatureLen, IntPtr pData, ref UInt32 pulDataLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
