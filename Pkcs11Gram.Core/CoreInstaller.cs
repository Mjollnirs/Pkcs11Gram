// Project: Pkcs11Gram.Core
// File: CoreInstaller.cs
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
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pkcs11Gram.Core.Dependency;
using Pkcs11Gram.Core.Runtime;
using System.Reflection;

namespace Pkcs11Gram.Core
{
    public sealed class CoreInstaller : InstallerBase
    {
        public override void Install(IWindsorContainer container, IConfigurationStore store)
        {
            base.Install(container, store);

            container.Register(Classes.FromAssembly(typeof(CoreInstaller).Assembly)
                .IncludeNonPublicTypes()
                .BasedOn<ITransient>()
                .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                .WithService.Self()
                .WithService.DefaultInterfaces()
                .LifestyleTransient()
                .Configure(x => x.Interceptors<DefaultInterceptor>()));

            container.Register(Classes.FromAssembly(typeof(CoreInstaller).Assembly)
                .IncludeNonPublicTypes()
                .BasedOn<ISingleton>()
                .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                .WithService.Self()
                .WithService.DefaultInterfaces()
                .LifestyleSingleton()
                .Configure(x => x.Interceptors<DefaultInterceptor>()));

            container.Register(Classes.FromAssembly(typeof(CoreInstaller).Assembly)
                .IncludeNonPublicTypes()
                .BasedOn<IInterceptor>()
                .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                .WithService.Self()
                .WithService.DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}
