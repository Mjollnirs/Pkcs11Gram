// Project: Pkcs11Gram.Loader
// File: EngineKey.cs
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
        public Rv C_GenerateKey(UInt32 hSession, ref Mechanism pMechanism, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount, ref UInt32 phKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_GenerateKeyPair(UInt32 hSession, ref Mechanism pMechanism, ref Core.Pkcs11.Attribute pPublicKeyTemplate, UInt32 ulPublicKeyAttributeCount, ref Core.Pkcs11.Attribute pPrivateKeyTemplate, UInt32 ulPrivateKeyAttributeCount, ref UInt32 phPublicKey, ref UInt32 phPrivateKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_WrapKey(UInt32 hSession, ref Mechanism pMechanism, UInt32 hWrappingKey, UInt32 hKey, IntPtr pWrappedKey, ref UInt32 pulWrappedKeyLen)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_UnwrapKey(UInt32 hSession, ref Mechanism pMechanism, UInt32 hUnwrappingKey, IntPtr pWrappedKey, UInt32 ulWrappedKeyLen, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulAttributeCount, ref UInt32 phKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public Rv C_DeriveKey(UInt32 hSession, ref Mechanism pMechanism, UInt32 hBaseKey, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulAttributeCount, ref UInt32 phKey)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
