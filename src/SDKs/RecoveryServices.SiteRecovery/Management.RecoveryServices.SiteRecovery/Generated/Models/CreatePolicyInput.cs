// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Protection profile input.
    /// </summary>
    public partial class CreatePolicyInput
    {
        /// <summary>
        /// Initializes a new instance of the CreatePolicyInput class.
        /// </summary>
        public CreatePolicyInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatePolicyInput class.
        /// </summary>
        /// <param name="properties">Policy creation properties.</param>
        public CreatePolicyInput(CreatePolicyInputProperties properties = default(CreatePolicyInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy creation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreatePolicyInputProperties Properties { get; set; }

    }
}
