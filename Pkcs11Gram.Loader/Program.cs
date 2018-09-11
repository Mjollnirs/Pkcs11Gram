// Project: Pkcs11Gram.Loader
// File: Program.cs
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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.Services.Logging.Log4netIntegration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Pkcs11Gram.Core.Runtime;
using Pkcs11Gram.Core.Slot;
using Pkcs11Gram.Loader.EntryPoint;
using Pkcs11Gram.Loader.Runtime;

namespace Pkcs11Gram.Loader
{
    class Program
    {
        private static List<string> dirList;
        private static ILogger Logger;
        private static IWindsorContainer WindsorContainer = Proxy.WindsorContainer;

        static void Main(string[] args)
        {
            if (!WindsorContainer.Kernel.HasComponent(typeof(IApp)))
            {
                string baseDirectory = args.Length >= 1 ? args[0] : AppDomain.CurrentDomain.BaseDirectory;

                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

                try
                {
                    WindsorContainer.Register(Component.For<IApp>()
                        .ImplementedBy<App>()
                        .IsDefault()
                        .LifestyleSingleton()
                        .UsingFactoryMethod((kernel) =>
                        {
                            return new App(kernel)
                            {
                                BaseDirectory = baseDirectory,
                            };
                        }));

                    dirList = new string[] {
                        baseDirectory,
                        Path.Combine(baseDirectory, "..\\", "TokenProvider"),
                        Path.Combine(baseDirectory, "..\\", "Library")
                    }.ToList();

                    dirList.ForEach(item =>
                    {
                        if (!Directory.Exists(item))
                            Directory.CreateDirectory(item);
                    });

                    var app = WindsorContainer.Resolve<IApp>();
                    WindsorContainer.AddFacility<LoggingFacility>(f => f.LogUsing<Log4netFactory>().WithConfig(Path.Combine(app.BaseDirectory, "log4net.config")));
                    Logger = app.Logger;

                    WindsorContainer.Install(dirList.Select(item =>
                    {
                        return FromAssembly.InDirectory(new AssemblyFilter(item));
                    }).ToArray());

                    Logger?.DebugFormat("App Sartup {0}!", app.SartupTime);

                    WindsorContainer.Register(Component.For<IEngine>()
                        .ImplementedBy<Engine>()
                        .Interceptors<EngineInterceptor>()
                        .LifestyleSingleton());

                    WindsorContainer.Register(Component.For<IProxy>()
                        .ImplementedBy<Proxy>()
                        .LifestyleSingleton());
                }
                catch (Exception ex)
                {
                    Logger?.Error("Unhandled Exception", ex);
                    throw ex;
                }
            }
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly assembly = null;
            Logger?.DebugFormat("Try Resolve Assembly: {0}", args.Name);
            foreach (var item in dirList)
            {
                string assemblyFile = $"{args.Name.Split(',').First()}.dll";
                string assemblyPath = Path.Combine(item, assemblyFile);
                if (File.Exists(assemblyPath))
                {
                    assembly = Assembly.LoadFile(assemblyPath);
                    Logger?.DebugFormat("Resolve Assembly Suceess: {0} {1}", args.Name, assemblyPath);
                    break;
                }
            }

            return assembly;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Logger?.Error("Unhandled Exception", (Exception)e.ExceptionObject);
        }
    }
}
