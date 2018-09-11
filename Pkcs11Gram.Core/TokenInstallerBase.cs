// Project: Pkcs11Gram.Core
// File: TokenInstallerBase.cs
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
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pkcs11Gram.Core.Runtime;
using Pkcs11Gram.Core.Slot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core
{
    public abstract class SlotInstallerBase<TProvider, TSlot, TToken, TSession> : InstallerBase
        where TProvider : ProviderBase<TSlot, TToken, TSession> ,IProvider
        where TSlot: class, ISlot
        where TToken: class, IToken
        where TSession: class, ISession
    {
        private IWindsorContainer Container;

        public abstract void Pre();
        public abstract void Post();

        public sealed override void Install(IWindsorContainer container, IConfigurationStore store)
        {
            Container = container;
            base.Install(container, store);
            Pre();
            Container.Register(Component.For<TSlot>()
                .ImplementedBy<TSlot>()
                .Interceptors<SlotInterceptor>()
                .LifestyleTransient());

            Container.Register(Component.For<TToken>()
                .ImplementedBy<TToken>()
                .Interceptors<TokenInterceptor>()
                .LifestyleTransient());

            Container.Register(Component.For<TSession>()
                .ImplementedBy<TSession>()
                .Interceptors<SessionInterceptor>()
                .LifestyleTransient());

            container.Register(Component.For<IProvider>()
                .ImplementedBy<TProvider>()
                .Interceptors<ProviderInterceptor>()
                .LifestyleSingleton());
            Post();
        }
    }

    public abstract class InstallerBase : IWindsorInstaller
    {
        private IWindsorContainer Container;

        public virtual void Install(IWindsorContainer container, IConfigurationStore store)
        {
            Container = container;
        }

        protected void RegisterTransient<TService, TImpl>()
            where TService: class
            where TImpl : TService
        {
            Container.Register(Component.For<TService>()
                .ImplementedBy<TImpl>()
                .Interceptors<DefaultInterceptor>()
                .LifestyleTransient());
        }

        protected void RegisterSingleton<TService, TImpl>()
            where TService : class
            where TImpl : TService
        {
            Container.Register(Component.For<TService>()
                .ImplementedBy<TImpl>()
                .Interceptors<DefaultInterceptor>()
                .LifestyleSingleton());
        }
    }
}
