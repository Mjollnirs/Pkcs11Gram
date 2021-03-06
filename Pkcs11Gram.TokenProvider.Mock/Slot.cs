﻿// Project: Pkcs11Gram.TokenProvider.Mock
// File: Slot.cs
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
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Runtime;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.TokenProvider.Mock
{
    public class Slot : SlotBase<Token, Session>
    {
        public Slot()
            : base(
                  "Pkcs11Gram Mock TokenProvider",
                  "Mjollnir<mjollnir@59k.org>")
        {
            IsRemoveable = true;
            HasToken = true;
        }

        protected override async Task<Token> ProcessToken(Token token)
        {
            await Task.Yield();
            return token;
        }
    }
}
