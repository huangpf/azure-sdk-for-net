// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup item representing a classic virtual
    /// machine.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.ClassicCompute/virtualMachines")]
    public partial class AzureIaaSClassicComputeVMContainer : IaaSVMContainer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSClassicComputeVMContainer class.
        /// </summary>
        public AzureIaaSClassicComputeVMContainer() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSClassicComputeVMContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerType">Type of the container. The value of
        /// this property for: 1. Compute Azure VM is
        /// Microsoft.Compute/virtualMachines 2. Classic Compute Azure VM is
        /// Microsoft.ClassicCompute/virtualMachines 3. Windows machines
        /// (like MAB, DPM etc) is Windows 4. Azure SQL instance is
        /// AzureSqlContainer.</param>
        /// <param name="virtualMachineId">Fully qualified ARM url of the
        /// virtual machine represented by this Azure IaaS VM
        /// container.</param>
        /// <param name="virtualMachineVersion">Specifies whether the
        /// container represents a Classic or an Azure Resource Manager
        /// VM.</param>
        /// <param name="resourceGroup">Resource group name of Recovery
        /// Services Vault.</param>
        public AzureIaaSClassicComputeVMContainer(string friendlyName = default(string), BackupManagementType? backupManagementType = default(BackupManagementType?), string registrationStatus = default(string), string healthStatus = default(string), string containerType = default(string), string virtualMachineId = default(string), string virtualMachineVersion = default(string), string resourceGroup = default(string))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, virtualMachineId, virtualMachineVersion, resourceGroup)
        {
        }

    }
}
