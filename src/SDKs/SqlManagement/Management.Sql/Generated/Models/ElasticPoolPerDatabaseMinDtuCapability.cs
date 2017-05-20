// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The minimum per-database DTU capability.
    /// </summary>
    public partial class ElasticPoolPerDatabaseMinDtuCapability
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ElasticPoolPerDatabaseMinDtuCapability class.
        /// </summary>
        public ElasticPoolPerDatabaseMinDtuCapability()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ElasticPoolPerDatabaseMinDtuCapability class.
        /// </summary>
        /// <param name="limit">The maximum DTUs per database.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        public ElasticPoolPerDatabaseMinDtuCapability(long? limit = default(long?), CapabilityStatus? status = default(CapabilityStatus?))
        {
            Limit = limit;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the maximum DTUs per database.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

    }
}
