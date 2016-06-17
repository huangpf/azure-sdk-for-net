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
    /// A Data Lake Analytics catalog U-SQL procedure item.
    /// </summary>
    public partial class USqlProcedure : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlProcedure class.
        /// </summary>
        public USqlProcedure() { }

        /// <summary>
        /// Initializes a new instance of the USqlProcedure class.
        /// </summary>
        public USqlProcedure(string computeAccountName = default(string), Guid? version = default(Guid?), string databaseName = default(string), string schemaName = default(string), string name = default(string), string definition = default(string))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            Name = name;
            Definition = definition;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this procedure
        /// and database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the procedure.
        /// </summary>
        [JsonProperty(PropertyName = "procName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the defined query of the procedure.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public string Definition { get; set; }

    }
}
