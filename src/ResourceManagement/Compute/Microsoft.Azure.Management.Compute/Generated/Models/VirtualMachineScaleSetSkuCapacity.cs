// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes scaling information of a sku.
    /// </summary>
    public partial class VirtualMachineScaleSetSkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetSkuCapacity class.
        /// </summary>
        public VirtualMachineScaleSetSkuCapacity() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetSkuCapacity class.
        /// </summary>
        /// <param name="minimum">the minimum capacity.</param>
        /// <param name="maximum">the maximum capacity that can be set.</param>
        /// <param name="defaultCapacity">the default capacity.</param>
        /// <param name="scaleType">the scale type applicable to the sku.
        /// Possible values include: 'Automatic', 'None'</param>
        public VirtualMachineScaleSetSkuCapacity(long? minimum = default(long?), long? maximum = default(long?), long? defaultCapacity = default(long?), VirtualMachineScaleSetSkuScaleType? scaleType = default(VirtualMachineScaleSetSkuScaleType?))
        {
            Minimum = minimum;
            Maximum = maximum;
            DefaultCapacity = defaultCapacity;
            ScaleType = scaleType;
        }

        /// <summary>
        /// Gets the minimum capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimum")]
        public long? Minimum { get; private set; }

        /// <summary>
        /// Gets the maximum capacity that can be set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maximum")]
        public long? Maximum { get; private set; }

        /// <summary>
        /// Gets the default capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultCapacity")]
        public long? DefaultCapacity { get; private set; }

        /// <summary>
        /// Gets the scale type applicable to the sku. Possible values
        /// include: 'Automatic', 'None'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scaleType")]
        public VirtualMachineScaleSetSkuScaleType? ScaleType { get; private set; }

    }
}
