// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The List data factory gateways operation response.
    /// </summary>
    public partial class GatewayListResponse : OperationResponse, IEnumerable<Gateway>
    {
        private IList<Gateway> _gateways;
        
        /// <summary>
        /// Optional. List of data factory gateway information.
        /// </summary>
        public IList<Gateway> Gateways
        {
            get { return this._gateways; }
            set { this._gateways = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayListResponse class.
        /// </summary>
        public GatewayListResponse()
        {
            this.Gateways = new LazyList<Gateway>();
        }
        
        /// <summary>
        /// Gets the sequence of Gateways.
        /// </summary>
        public IEnumerator<Gateway> GetEnumerator()
        {
            return this.Gateways.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Gateways.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
