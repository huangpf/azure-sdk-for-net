// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL database item.
    /// </summary>
    public partial class USqlDatabase : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlDatabase class.
        /// </summary>
        public USqlDatabase() { }

        /// <summary>
        /// Initializes a new instance of the USqlDatabase class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="name">the name of the database.</param>
        public USqlDatabase(string computeAccountName = default(string), Guid? version = default(Guid?), string name = default(string))
            : base(computeAccountName, version)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string Name { get; set; }

    }
}
