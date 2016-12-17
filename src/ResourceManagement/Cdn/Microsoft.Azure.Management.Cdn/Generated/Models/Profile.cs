// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CDN profile represents the top level resource and the entry point into
    /// the CDN API. This allows users to set up a logical grouping of
    /// endpoints in addition to creating shared configuration settings and
    /// selecting pricing tiers and providers.
    /// </summary>
    [JsonTransformation]
    public partial class Profile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile() { }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="sku">The pricing tier (defines a CDN provider, feature
        /// list and rate) of the CDN profile.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="resourceState">Resource status of the profile.
        /// Possible values include: 'Creating', 'Active', 'Deleting',
        /// 'Disabled'</param>
        /// <param name="provisioningState">Provisioning status of the
        /// profile.</param>
        public Profile(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string resourceState = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the pricing tier (defines a CDN provider, feature list
        /// and rate) of the CDN profile.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets resource status of the profile. Possible values include:
        /// 'Creating', 'Active', 'Deleting', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; protected set; }

        /// <summary>
        /// Gets provisioning status of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
        }
    }
}

