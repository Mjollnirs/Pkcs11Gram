// Project: Pkcs11Gram.Loader
// File: EngineMessageDigesting.cs
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
        public static Rv C_DigestInit(UInt32 hSession, ref Mechanism pMechanism)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_Digest(UInt32 hSession, IntPtr pData, UInt32 ulDataLen, IntPtr pDigest, ref UInt32 pulDigestLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_DigestUpdate(UInt32 hSession, IntPtr pPart, UInt32 ulPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_DigestKey(UInt32 hSession, UInt32 hKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_DigestFinal(UInt32 hSession, IntPtr pDigest, ref UInt32 pulDigestLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
