using Pkcs11Gram.Core.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pkcs11Gram.Core.Slot
{
    public interface IBase
    {
        IApp App { get; }
    }
}
