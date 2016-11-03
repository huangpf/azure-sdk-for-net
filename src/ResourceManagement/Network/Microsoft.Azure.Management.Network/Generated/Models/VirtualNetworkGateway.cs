// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
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
    /// A common class for general resource information
    /// </summary>
    [JsonTransformation]
    public partial class VirtualNetworkGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGateway class.
        /// </summary>
        public VirtualNetworkGateway() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGateway class.
        /// </summary>
        public VirtualNetworkGateway(IList<VirtualNetworkGatewayIPConfiguration> ipConfigurations, string gatewayType, string vpnType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enableBgp = default(bool?), bool? activeActive = default(bool?), SubResource gatewayDefaultSite = default(SubResource), VirtualNetworkGatewaySku sku = default(VirtualNetworkGatewaySku), VpnClientConfiguration vpnClientConfiguration = default(VpnClientConfiguration), BgpSettings bgpSettings = default(BgpSettings), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            IpConfigurations = ipConfigurations;
            GatewayType = gatewayType;
            VpnType = vpnType;
            EnableBgp = enableBgp;
            ActiveActive = activeActive;
            GatewayDefaultSite = gatewayDefaultSite;
            Sku = sku;
            VpnClientConfiguration = vpnClientConfiguration;
            BgpSettings = bgpSettings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// IpConfigurations for Virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<VirtualNetworkGatewayIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// The type of this virtual network gateway. Possible values include:
        /// 'Vpn', 'ExpressRoute'
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayType")]
        public string GatewayType { get; set; }

        /// <summary>
        /// The type of this virtual network gateway. Possible values include:
        /// 'PolicyBased', 'RouteBased'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnType")]
        public string VpnType { get; set; }

        /// <summary>
        /// EnableBgp Flag
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// ActiveActive flag
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeActive")]
        public bool? ActiveActive { get; set; }

        /// <summary>
        /// Gets or sets the reference of the LocalNetworkGateway resource
        /// which represents Local network site having default routes. Assign
        /// Null value in case of removing existing default site setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayDefaultSite")]
        public SubResource GatewayDefaultSite { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VirtualNetworkGatewaySku
        /// resource which represents the sku selected for Virtual network
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public VirtualNetworkGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VpnClientConfiguration resource
        /// which represents the P2S VpnClient configurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConfiguration")]
        public VpnClientConfiguration VpnClientConfiguration { get; set; }

        /// <summary>
        /// Virtual network gateway's BGP speaker settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the VirtualNetworkGateway
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets provisioning state of the VirtualNetworkGateway resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (IpConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpConfigurations");
            }
            if (GatewayType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GatewayType");
            }
            if (VpnType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VpnType");
            }
            if (this.IpConfigurations != null)
            {
                foreach (var element in this.IpConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
        }
    }
}
