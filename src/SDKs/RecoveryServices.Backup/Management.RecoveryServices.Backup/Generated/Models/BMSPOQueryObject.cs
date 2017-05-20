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
    /// Filters to list items that can be backed up.
    /// </summary>
    public partial class BMSPOQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSPOQueryObject class.
        /// </summary>
        public BMSPOQueryObject()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BMSPOQueryObject class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="status">Backup status query parameter.</param>
        /// <param name="friendlyName">Friendly name.</param>
        public BMSPOQueryObject(string backupManagementType = default(string), string status = default(string), string friendlyName = default(string))
        {
            BackupManagementType = backupManagementType;
            Status = status;
            FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup management type. Possible values include:
        /// 'Invalid', 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets backup status query parameter.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

    }
}
