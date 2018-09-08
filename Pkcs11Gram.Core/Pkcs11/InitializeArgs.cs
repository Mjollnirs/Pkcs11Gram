// Project: Pkcs11Gram.Core
// File: InitializeArgs.cs
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
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_C_INITIALIZE_ARGS is a structure containing 
    /// the optional arguments for the C_Initialize function.
    /// For this version of Cryptoki, these optional arguments 
    /// are all concerned with the way the library deals with threads.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct InitializeArgs
    {
        public CreateMutex CreateMutex;

        public DestoryMutex DestoryMutex;

        public LockMutex LockMutex;

        public UnlockMutex UnlockMutex;

        public InitializeFlags Flags;

        public IntPtr pReserved;
    }
}
