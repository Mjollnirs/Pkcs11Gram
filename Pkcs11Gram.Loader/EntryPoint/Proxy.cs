using Castle.Core.Logging;
using Castle.DynamicProxy;
using Castle.DynamicProxy.Generators;
using Castle.Windsor;
using Pkcs11Gram.Core.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Pkcs11Gram.Loader.EntryPoint
{
    internal sealed class Proxy : IProxy
    {
        internal static IWindsorContainer WindsorContainer = new WindsorContainer();

        public static int Inject([MarshalAs(UnmanagedType.LPWStr)]string functionName, ref IntPtr function)
        {
            try
            {
                Proxy proxy = (Proxy)WindsorContainer.Resolve<IProxy>();
                function = proxy.Process(functionName).Result;
                return 0;
            }
            catch (Exception ex)
            {
                WindsorContainer.Resolve<IApp>()?.Logger?.Debug("Inject Faild", ex);
                throw;
            }
        }

        private readonly ILogger _logger;
        private readonly IApp _app;
        private readonly IEngine _engine;
        private IList<Type> DelegateType { get; set; } = new List<Type>();

        public Proxy(IApp app, ILogger logger, IEngine engine)
        {
            _app = app;
            _logger = logger;
            _engine = engine;
            BuildEngineDelegate();
        }

        internal async Task<IntPtr> Process(string functionName)
        {
            _logger.DebugFormat("Process Inject {0}", functionName);
            Delegate @delegate = Proxy_ProcessInject(functionName);
            await Task.Yield();
            return Marshal.GetFunctionPointerForDelegate(@delegate);
        }

        private Delegate Proxy_ProcessInject(string functionName)
        {
            MethodInfo methodInfo = _engine.GetType().GetMethods().Where(x => x.Name == functionName).FirstOrDefault();
            Type delegateType = DelegateType.Where(x => x.Name == functionName).FirstOrDefault();

            if (methodInfo != null && delegateType != null)
            {
                _logger.DebugFormat("Found {0} {1} Function!", methodInfo.ReflectedType.FullName, methodInfo.Name);
                return methodInfo.CreateDelegate(delegateType, _engine);
            }
            else
            {
                _logger.DebugFormat("Proxy Not Found Function {0}", functionName);
                throw new ArgumentException();
            }
        }

        private void BuildEngineDelegate()
        {
            string name = "Pkcs11GramEngineLoaderProxyDelegate";
            AssemblyName assemblyName = new AssemblyName(name);
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(name);

            IList<MethodInfo> methods = _engine.GetType().GetMethods().ToArray();
            foreach (var item in methods)
            {
                TypeBuilder typeBuilder = moduleBuilder.DefineType($"{item.Name}",
                    TypeAttributes.Public | TypeAttributes.AutoLayout | TypeAttributes.AnsiClass | TypeAttributes.Sealed,
                    typeof(MulticastDelegate));

                ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName,
                    CallingConventions.Standard, item.GetParameters().Select(x => x.ParameterType).ToArray());
                constructorBuilder.SetImplementationFlags(MethodImplAttributes.Runtime);

                MethodBuilder methodBuilder = typeBuilder.DefineMethod("Invoke",
                    MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.NewSlot | MethodAttributes.Virtual,
                    CallingConventions.Standard, item.ReturnType, item.GetParameters().Select(x => x.ParameterType).ToArray());
                methodBuilder.SetImplementationFlags(MethodImplAttributes.Runtime);

                DelegateType.Add(typeBuilder.CreateType());
            }
        }
    }
}
