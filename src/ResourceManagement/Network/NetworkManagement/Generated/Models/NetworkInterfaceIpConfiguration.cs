// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// IPConfiguration in a NetworkInterface
    /// </summary>
    public partial class NetworkInterfaceIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceIPConfiguration
        /// class.
        /// </summary>
        public NetworkInterfaceIPConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceIPConfiguration
        /// class.
        /// </summary>
        public NetworkInterfaceIPConfiguration(string name = default(string), string etag = default(string), IList<BackendAddressPool> loadBalancerBackendAddressPools = default(IList<BackendAddressPool>), IList<InboundNatRule> loadBalancerInboundNatRules = default(IList<InboundNatRule>), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), Subnet subnet = default(Subnet), PublicIPAddress publicIPAddress = default(PublicIPAddress), string provisioningState = default(string))
        {
            Name = name;
            Etag = etag;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the reference of LoadBalancerBackendAddressPool
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerBackendAddressPools")]
        public IList<BackendAddressPool> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets list of references of LoadBalancerInboundNatRules
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerInboundNatRules")]
        public IList<InboundNatRule> LoadBalancerInboundNatRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public PublicIPAddress PublicIPAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.LoadBalancerInboundNatRules != null)
            {
                foreach (var element in this.LoadBalancerInboundNatRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Subnet != null)
            {
                this.Subnet.Validate();
            }
            if (this.PublicIPAddress != null)
            {
                this.PublicIPAddress.Validate();
            }
        }
    }
}
