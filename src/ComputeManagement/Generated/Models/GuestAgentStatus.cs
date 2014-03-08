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
using System.Linq;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Optional. Guest Agent Status.
    /// </summary>
    public partial class GuestAgentStatus
    {
        private FormattedMessage _formattedMessage;
        
        /// <summary>
        /// Formatted Message.
        /// </summary>
        public FormattedMessage FormattedMessage
        {
            get { return this._formattedMessage; }
            set { this._formattedMessage = value; }
        }
        
        private string _guestAgentVersion;
        
        /// <summary>
        /// Guest Agent Version.
        /// </summary>
        public string GuestAgentVersion
        {
            get { return this._guestAgentVersion; }
            set { this._guestAgentVersion = value; }
        }
        
        private string _protocolVersion;
        
        /// <summary>
        /// Protocol Version.
        /// </summary>
        public string ProtocolVersion
        {
            get { return this._protocolVersion; }
            set { this._protocolVersion = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _timestamp;
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GuestAgentStatus class.
        /// </summary>
        public GuestAgentStatus()
        {
        }
    }
}
