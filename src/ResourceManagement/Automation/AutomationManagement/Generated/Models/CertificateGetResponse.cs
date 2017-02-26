// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the get certificate operation.
    /// </summary>
    public partial class CertificateGetResponse : AzureOperationResponse
    {
        private Certificate _certificate;
        
        /// <summary>
        /// Optional. Gets or sets a certificate.
        /// </summary>
        public Certificate Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CertificateGetResponse class.
        /// </summary>
        public CertificateGetResponse()
        {
        }
    }
}
