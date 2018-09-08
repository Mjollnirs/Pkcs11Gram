// Project: Pkcs11Gram.Core
// File: RollingFileAppender.cs
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
using System.Text;
using RollingFileAppenderBase = log4net.Appender.RollingFileAppender;

namespace Pkcs11Gram.Core.Runtime
{
    public class RollingFileAppender : RollingFileAppenderBase
    {
        private readonly IApp app;

        public override string File
        {
            get
            {
                return base.File;
            }
            set
            {
                base.File = Path.Combine(app.BaseDirectory, value);
            }
        }

        public RollingFileAppender()
            : base()
        {
            app = AppBase.Container.Resolve<IApp>();
        }
    }
}
