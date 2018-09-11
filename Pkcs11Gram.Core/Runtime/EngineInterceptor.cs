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
