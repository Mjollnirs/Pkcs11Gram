// Project: Pkcs11Gram.Core
// File: UnlockMutex.cs
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
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_UNLOCKMUTEX is the type of a pointer to an application-supplied
    /// function which unlocks an existing mutex object. 
    /// </summary>
    /// <param name="pMutex"></param>
    /// <returns></returns>
    public delegate Rv UnlockMutex(IntPtr pMutex);
}
