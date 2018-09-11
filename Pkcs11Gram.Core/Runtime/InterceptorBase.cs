// Project: Pkcs11Gram.Core
// File: InterceptorBase.cs
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
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Runtime
{
    public abstract class InterceptorBase : IInterceptor
    {
        private readonly IKernel kernel;
        protected ILogger Logger { get; private set; }

        public InterceptorBase(IKernel _kernel, ILogger _logger)
        {
            kernel = _kernel;
            Logger = _logger;
        }

        public virtual void Intercept(IInvocation invocation)
        {
            try
            {
                Logger.DebugFormat("Enter {0} {1}" ,invocation.Method.ReflectedType.FullName, invocation.Method.Name);
                invocation.Proceed();
                if(invocation.ReturnValue is Task)
                {
                    Task task = (Task)invocation.ReturnValue;

                    if (task.IsFaulted)
                        throw task.Exception;
                }
            }
            catch (System.Exception ex)
            {
                Logger.ErrorFormat(ex, "Interceptor Error!");
                throw ex;
            }
        }
    }
}
