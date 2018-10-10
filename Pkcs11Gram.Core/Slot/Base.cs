using System;
using System.Collections.Generic;
using System.Text;
using Castle.MicroKernel;
using Pkcs11Gram.Core.Runtime;

namespace Pkcs11Gram.Core.Slot
{
    public abstract class Base : IBase
    {
        protected IKernel Kernel { get { return App.Kernel; } }
        internal AppBase AppBase { get { return (AppBase)App; } }
        public IApp App { get; internal set; }

        public Base()
        {
            App = AppBase.Container.Resolve<IApp>();
        }
    }
}
