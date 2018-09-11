// Project: Pkcs11Gram.Loader
// File: EngineEncryption.cs
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
        public Rv C_EncryptInit(UInt32 hSession, ref Mechanism pMechanism, UInt32 hKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_Encrypt(UInt32 hSession, IntPtr pData, UInt32 ulDataLen, IntPtr pEncryptedData, ref UInt32 pulEncryptedDataLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_EncryptUpdate(UInt32 hSession, IntPtr pPart, UInt32 ulPartLen, IntPtr pEncryptedPart, ref UInt32 pulEncryptedPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_EncryptFinal(UInt32 hSession, IntPtr pLastEncryptedPart, ref UInt32 pulLastEncryptedPartLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
