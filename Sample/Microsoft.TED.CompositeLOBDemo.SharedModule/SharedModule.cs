﻿﻿//	Copyright (c) Max Knor, Microsoft
//	All rights reserved. 
//	http://blog.knor.net/
//
//	Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 
//	THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 
//
//	See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Microsoft.TED.WinRT.Modules;

namespace Microsoft.TED.CompositeLOBDemo.SharedModule
{
    public class Module : IModule
    {
        private readonly SimpleContainer _container;

        public Module(SimpleContainer container)
        {
            _container = container;
        }

        public async Task InitializeAsync()
        {
            _container.RegisterPerRequest(typeof(ISearchImages), "", typeof(BingImageSearch));

            await Task.FromResult<object>(null);
        }
    }
}
