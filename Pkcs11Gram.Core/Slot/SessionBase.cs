// Project: Pkcs11Gram.Core
// File: SessionBase.cs
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
using Castle.MicroKernel;
using Pkcs11Gram.Core.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core.Slot
{
    public abstract class SessionBase : Base, ISession
    {
        public DateTime CreateTime { get; private set; }

        public IToken Token { get; internal set; }

        public SessionBase()
        {
            CreateTime = DateTime.Now;
        }
    }
}
