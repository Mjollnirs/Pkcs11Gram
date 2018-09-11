// Project: Pkcs11Gram.Loader
// File: EngineDecryption.cs
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
    internal partial class Engine
    {
        public Rv C_DecryptInit(UInt32 hSession, ref Mechanism pMechanism, UInt32 hKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_Decrypt(UInt32 hSession, IntPtr pEncryptedData, UInt32 ulEncryptedDataLen, IntPtr pData, ref UInt32 pulDataLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_DecryptUpdate(UInt32 hSession, IntPtr pEncryptedPart, UInt32 ulEncryptedPartLen, IntPtr pPart, ref UInt32 pulPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_DecryptFinal(UInt32 hSession, IntPtr pLastPart, ref UInt32 pulLastPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
