// Project: Pkcs11Gram.Loader
// File: EngineObject.cs
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
        public static Rv C_CreateObject(UInt32 hSession, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount, ref UInt32 phObject)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_CopyObject(UInt32 hSession, UInt32 hObject, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount, ref UInt32 phNewObject)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_DestroyObject(UInt32 hSession, UInt32 hObject)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_GetObjectSize(UInt32 hSession, UInt32 hObject, ref UInt32 pulSize)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_GetAttributeValue(UInt32 hSession, UInt32 hObject, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_SetAttributeValue(UInt32 hSession, UInt32 hObject, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_FindObjectsInit(UInt32 hSession, ref Core.Pkcs11.Attribute pTemplate, UInt32 ulCount)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_FindObjects(UInt32 hSession, ref UInt32 phObject, UInt32 ulMaxObjectCount, ref UInt32 pulObjectCount)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }

        public static Rv C_FindObjectsFinal(UInt32 hSession)
        {
            return Rv.FUNCTION_NOT_SUPPORTED;
        }
    }
}
