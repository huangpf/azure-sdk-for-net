// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Value of resource metric
    /// </summary>
    public partial class ResourceMetricValue
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        public ResourceMetricValue() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        public ResourceMetricValue(string timestamp = default(string), double? average = default(double?), double? minimum = default(double?), double? maximum = default(double?), double? total = default(double?), double? count = default(double?), IList<ResourceMetricProperty> properties = default(IList<ResourceMetricProperty>))
        {
            Timestamp = timestamp;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            Total = total;
            Count = count;
            Properties = properties;
        }

        /// <summary>
        /// Value timestamp
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; private set; }

        /// <summary>
        /// Value average
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Value minimum
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; private set; }

        /// <summary>
        /// Value maximum
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; private set; }

        /// <summary>
        /// Value total
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; private set; }

        /// <summary>
        /// Value count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; private set; }

        /// <summary>
        /// Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<ResourceMetricProperty> Properties { get; private set; }

    }
}
