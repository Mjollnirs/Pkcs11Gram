// Project: Pkcs11Gram.Core
// File: Pkcs11Exception.cs
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
using Pkcs11Gram.Core.Pkcs11;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Pkcs11Gram.Core.Exception
{

    [Serializable]
    public class Pkcs11Exception : System.Exception
    {
        public Rv Pkcs11Rv { get; private set; } = Rv.GENERAL_ERROR;

        public Pkcs11Exception(string message)
            : base(message)
        {
        }

        public Pkcs11Exception(string message, Rv rv)
            : base(message)
        {
            Pkcs11Rv = rv;
        }

        public Pkcs11Exception(string message, Rv rv, System.Exception inner)
            : base(message, inner)
        {
            Pkcs11Rv = rv;
        }

        protected Pkcs11Exception(
          SerializationInfo info,
          StreamingContext context) : base(info, context)
        {
            if (info != null)
            {
                Pkcs11Rv = (Rv)info.GetUInt32("Pkcs11Rv");
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                info.AddValue("Pkcs11Rv", Pkcs11Rv);
            }
            base.GetObjectData(info, context);
        }
    }
}
