// Project: Pkcs11Gram.Loader
// File: EngineGeneral.cs
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
using Pkcs11Gram.Loader.Runtime;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Loader.EntryPoint
{
    internal partial class Engine : IEngine
    {
        public Rv C_Initialize(IntPtr pInitArgs)
        {
            if (App.IsInitialized)
                return Rv.CRYPTOKI_ALREADY_INITIALIZED;

            if (pInitArgs != IntPtr.Zero)
            {
                InitializeArgs args = Marshal.PtrToStructure<InitializeArgs>(pInitArgs);
            }

            App.Initialize().Wait();

            return Rv.OK;
        }

        public Rv C_Finalize(IntPtr pReserved)
        {
            if (!App.IsInitialized)
                return Rv.CRYPTOKI_NOT_INITIALIZED;

            App.Finalize().Wait();

            return Rv.OK;
        }

        public Rv C_GetInfo(ref Info pInfo)
        {
            if (!App.IsInitialized)
                return Rv.CRYPTOKI_NOT_INITIALIZED;

            pInfo.CryptokiVersion = App.FunctionList.version;
            pInfo.ManufacturerId = App.LibraryVersion.ManufacturerId;
            pInfo.LibraryDescription = App.LibraryVersion.Description;
            pInfo.LibraryVersion = App.LibraryVersion.Version;

            return Rv.OK;
        }

        public Rv C_GetFunctionList(ref FunctionList functionList)
        {
            if (App == null)
                return Rv.DEVICE_ERROR;

            App.FunctionList = functionList;

            return Rv.OK;
        }
    }
}
