// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Rest;
    using Rest.Serialization;
    using System.Linq;

    /// <summary>
    /// Azure Storage blob container information.
    /// </summary>
    [JsonTransformation]
    public partial class StorageContainer
    {
        /// <summary>
        /// Initializes a new instance of the StorageContainer class.
        /// </summary>
        public StorageContainer() { }

        /// <summary>
        /// Initializes a new instance of the StorageContainer class.
        /// </summary>
        /// <param name="name">the name of the blob container.</param>
        /// <param name="id">the unique identifier of the blob
        /// container.</param>
        /// <param name="type">the type of the blob container.</param>
        /// <param name="lastModifiedTime">the last modified time of the blob
        /// container.</param>
        public StorageContainer(string name = default(string), string id = default(string), string type = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?))
        {
            Name = name;
            Id = id;
            Type = type;
            LastModifiedTime = lastModifiedTime;
        }

        /// <summary>
        /// Gets the name of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets the unique identifier of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

        /// <summary>
        /// Gets the type of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }

        /// <summary>
        /// Gets the last modified time of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; protected set; }

    }
}



