// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional information on backup engine.
    /// </summary>
    public partial class BackupEngineExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the BackupEngineExtendedInfo class.
        /// </summary>
        public BackupEngineExtendedInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupEngineExtendedInfo class.
        /// </summary>
        /// <param name="databaseName">Database name of backup engine.</param>
        /// <param name="protectedItemsCount">Number of protected items in the
        /// backup engine.</param>
        /// <param name="protectedServersCount">Number of protected servers in
        /// the backup engine.</param>
        /// <param name="diskCount">Number of disks in the backup
        /// engine.</param>
        /// <param name="usedDiskSpace">Diskspace used in the backup
        /// engine.</param>
        /// <param name="availableDiskSpace">Diskspace currently available in
        /// the backup engine.</param>
        /// <param name="refreshedAt">Last refresh time in the backup
        /// engine.</param>
        /// <param name="azureProtectedInstances">Protected instances in the
        /// backup engine.</param>
        public BackupEngineExtendedInfo(string databaseName = default(string), int? protectedItemsCount = default(int?), int? protectedServersCount = default(int?), int? diskCount = default(int?), double? usedDiskSpace = default(double?), double? availableDiskSpace = default(double?), System.DateTime? refreshedAt = default(System.DateTime?), int? azureProtectedInstances = default(int?))
        {
            DatabaseName = databaseName;
            ProtectedItemsCount = protectedItemsCount;
            ProtectedServersCount = protectedServersCount;
            DiskCount = diskCount;
            UsedDiskSpace = usedDiskSpace;
            AvailableDiskSpace = availableDiskSpace;
            RefreshedAt = refreshedAt;
            AzureProtectedInstances = azureProtectedInstances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database name of backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets number of protected items in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemsCount")]
        public int? ProtectedItemsCount { get; set; }

        /// <summary>
        /// Gets or sets number of protected servers in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "protectedServersCount")]
        public int? ProtectedServersCount { get; set; }

        /// <summary>
        /// Gets or sets number of disks in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "diskCount")]
        public int? DiskCount { get; set; }

        /// <summary>
        /// Gets or sets diskspace used in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "usedDiskSpace")]
        public double? UsedDiskSpace { get; set; }

        /// <summary>
        /// Gets or sets diskspace currently available in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "availableDiskSpace")]
        public double? AvailableDiskSpace { get; set; }

        /// <summary>
        /// Gets or sets last refresh time in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "refreshedAt")]
        public System.DateTime? RefreshedAt { get; set; }

        /// <summary>
        /// Gets or sets protected instances in the backup engine.
        /// </summary>
        [JsonProperty(PropertyName = "azureProtectedInstances")]
        public int? AzureProtectedInstances { get; set; }

    }
}
