﻿// Project: Pkcs11Gram.Core
// File: EngineInterceptor.cs
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
using Castle.Core.Logging;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using Pkcs11Gram.Core.Exception;
using Pkcs11Gram.Core.Pkcs11;
using Pkcs11Gram.Core.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core.Runtime
{
    public sealed class EngineInterceptor : InterceptorBase
    {
        public EngineInterceptor(IKernel _kernel, ILogger _logger) : base(_kernel, _logger)
        {
        }

        public override void Intercept(IInvocation invocation)
        {
            try
            {
                base.Intercept(invocation);
            }
            catch (Pkcs11Exception ex)
            {
                invocation.ReturnValue = ex.Pkcs11Rv;
            }
            catch (System.Exception)
            {
                invocation.ReturnValue = Rv.GENERAL_ERROR;
            }
        }
    }
}
