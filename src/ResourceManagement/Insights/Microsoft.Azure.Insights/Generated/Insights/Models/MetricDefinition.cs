// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// Metric definition class specifies the metadata for a metric.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition() { }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        /// <param name="resourceId">the resource identifier of the resource
        /// that emitted the metric.</param>
        /// <param name="name">the name and the display name of the metric,
        /// i.e. it is a localizable string.</param>
        /// <param name="unit">the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'</param>
        /// <param name="primaryAggregationType">the primary aggregation type
        /// value defining how to use the values for display. Possible values
        /// include: 'None', 'Average', 'Count', 'Minimum', 'Maximum',
        /// 'Total'</param>
        /// <param name="metricAvailabilities">the collection of what
        /// aggregation intervals are available to be queried.</param>
        /// <param name="id">the resource identifier of the metric
        /// definition.</param>
        public MetricDefinition(string resourceId = default(string), LocalizableString name = default(LocalizableString), Unit? unit = default(Unit?), AggregationType? primaryAggregationType = default(AggregationType?), System.Collections.Generic.IList<MetricAvailability> metricAvailabilities = default(System.Collections.Generic.IList<MetricAvailability>), string id = default(string))
        {
            ResourceId = resourceId;
            Name = name;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            Id = id;
        }

        /// <summary>
        /// Gets or sets the resource identifier of the resource that emitted
        /// the metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name and the display name of the metric, i.e. it
        /// is a localizable string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public Unit? Unit { get; set; }

        /// <summary>
        /// Gets or sets the primary aggregation type value defining how to use
        /// the values for display. Possible values include: 'None', 'Average',
        /// 'Count', 'Minimum', 'Maximum', 'Total'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryAggregationType")]
        public AggregationType? PrimaryAggregationType { get; set; }

        /// <summary>
        /// Gets or sets the collection of what aggregation intervals are
        /// available to be queried.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metricAvailabilities")]
        public System.Collections.Generic.IList<MetricAvailability> MetricAvailabilities { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the metric definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name != null)
            {
                this.Name.Validate();
            }
        }
    }
}
