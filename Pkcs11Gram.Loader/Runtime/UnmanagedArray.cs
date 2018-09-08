// Project: Pkcs11Gram.Loader
// File: UnmanagedArray.cs
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

namespace Pkcs11Gram.Loader.Runtime
{
    internal static class UnmanagedArray
    {
        public static T[] PtrToStructureArray<T, TLength>(IntPtr ptr, IntPtr lengthPtr)
        {
            int length = Convert.ToInt32(Marshal.PtrToStructure<TLength>(lengthPtr));
            return PtrToStructureArray<T>(ptr, length);
        }

        public static T[] PtrToStructureArray<T>(IntPtr ptr, int length)
        {
            T[] result = new T[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = Marshal.PtrToStructure<T>(ptr + (i * Marshal.SizeOf<T>()));
            }

            return result;
        }

        public static void StructureArrayToPtr<T>(T[] array, IntPtr ptr)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Marshal.StructureToPtr<T>(array[i], ptr + (i * Marshal.SizeOf<T>()), false);
            }
        }
    }
}
