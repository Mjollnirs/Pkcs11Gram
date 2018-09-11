// Project: Pkcs11Gram.Pkcs11Test
// File: TestBase.cs
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
using System.IO;
using System.Collections.Generic;
using System.Text;
using Net.Pkcs11Interop.HighLevelAPI;
using Net.Pkcs11Interop.Common;

namespace Pkcs11Gram.Pkcs11Test
{
    public abstract class TestBase : IDisposable
    {
        private static object locker = new object();

        public const string SlnName = "Pkcs11Gram";
        public const string LibraryName = "x64\\Debug\\Pkcs11Gram.Engine.dll";

        private static Pkcs11 _pkcs11;
        protected Pkcs11 Pkcs11
        {
            get
            {
                lock (locker)
                {
                    if (_pkcs11 == null || _pkcs11.Disposed)
                        _pkcs11 = new Pkcs11(LibraryPath, AppType.MultiThreaded);

                    return _pkcs11;
                }
            }
        }

        public string LibraryPath
        {
            get
            {
                string @base = AppContext.BaseDirectory;
                string slnDir = @base.Remove(@base.IndexOfAny(SlnName.ToCharArray()) + SlnName.Length);

                return Path.Combine(slnDir, LibraryName);
            }
        }

        public void Dispose()
        {
            Pkcs11?.Dispose();
        }
    }
}
