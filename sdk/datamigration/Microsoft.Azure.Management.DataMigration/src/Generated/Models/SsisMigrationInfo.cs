// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSIS migration info with SSIS store type, overwrite policy.
    /// </summary>
    public partial class SsisMigrationInfo
    {
        /// <summary>
        /// Initializes a new instance of the SsisMigrationInfo class.
        /// </summary>
        public SsisMigrationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SsisMigrationInfo class.
        /// </summary>
        /// <param name="ssisStoreType">The SSIS store type of source, only
        /// SSIS catalog is supported now in DMS. Possible values include:
        /// 'SsisCatalog'</param>
        /// <param name="projectOverwriteOption">The overwrite option for the
        /// SSIS project migration. Possible values include: 'Ignore',
        /// 'Overwrite'</param>
        /// <param name="environmentOverwriteOption">The overwrite option for
        /// the SSIS environment migration. Possible values include: 'Ignore',
        /// 'Overwrite'</param>
        public SsisMigrationInfo(string ssisStoreType = default(string), string projectOverwriteOption = default(string), string environmentOverwriteOption = default(string))
        {
            SsisStoreType = ssisStoreType;
            ProjectOverwriteOption = projectOverwriteOption;
            EnvironmentOverwriteOption = environmentOverwriteOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SSIS store type of source, only SSIS catalog is
        /// supported now in DMS. Possible values include: 'SsisCatalog'
        /// </summary>
        [JsonProperty(PropertyName = "ssisStoreType")]
        public string SsisStoreType { get; set; }

        /// <summary>
        /// Gets or sets the overwrite option for the SSIS project migration.
        /// Possible values include: 'Ignore', 'Overwrite'
        /// </summary>
        [JsonProperty(PropertyName = "projectOverwriteOption")]
        public string ProjectOverwriteOption { get; set; }

        /// <summary>
        /// Gets or sets the overwrite option for the SSIS environment
        /// migration. Possible values include: 'Ignore', 'Overwrite'
        /// </summary>
        [JsonProperty(PropertyName = "environmentOverwriteOption")]
        public string EnvironmentOverwriteOption { get; set; }

    }
}