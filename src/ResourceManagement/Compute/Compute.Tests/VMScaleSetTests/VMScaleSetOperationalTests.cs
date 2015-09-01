//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Collections.Generic;
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Test;
using System.Net;
using Xunit;

namespace Compute.Tests
{
    public class VMScaleSetOperationalTests : VMScaleSetTestsBase
    {
        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet
        /// GET VMScaleSet Model View
        /// Start VMScaleSet
        /// Stop VMScaleSet
        /// Restart VMScaleSet
        /// Deallocate VMScaleSet
        /// Delete RG
        /// </summary>
        [Fact]
        public void TestVMScaleSetOperations()
        {
            using (var context = UndoContext.Current)
            {
                context.Start();
                EnsureClientsInitialized();

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);

                // Create resource group
                string rgName = TestUtilities.GenerateName(TestPrefix) + 1;
                string storageAccountName = TestUtilities.GenerateName(TestPrefix);
                VirtualMachineScaleSet inputVMScaleSet;

                bool passed = false;
                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    VirtualMachineScaleSet vmScaleSet = CreateVMScaleSet_NoAsyncTracking(rgName, storageAccountOutput, imageRef, out inputVMScaleSet);

                    var startOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginStarting(rgName, vmScaleSet.Name);
                    Assert.Equal(HttpStatusCode.Accepted, startOperationResponse.StatusCode);
                    ComputeLongRunningOperationResponse lroResponse = m_CrpClient.VirtualMachineScaleSets.Start(rgName, vmScaleSet.Name);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var restartOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginRestarting(rgName, vmScaleSet.Name);
                    Assert.Equal(HttpStatusCode.Accepted, restartOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.Restart(rgName, vmScaleSet.Name);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var stopOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginPoweringOff(rgName, vmScaleSet.Name);
                    Assert.Equal(HttpStatusCode.Accepted, stopOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.PowerOff(rgName, vmScaleSet.Name);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deallocateOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginDeallocating(rgName, vmScaleSet.Name);
                    Assert.Equal(HttpStatusCode.Accepted, deallocateOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.Deallocate(rgName, vmScaleSet.Name);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deleteResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, vmScaleSet.Name);
                    Assert.True(deleteResponse.Status != OperationStatus.Failed);

                    passed = true;
                }
                finally
                {
                    // Cleanup the created resources. But don't wait since it takes too long, and it's not the purpose
                    // of the test to cover deletion. CSM does persistent retrying over all RG resources.
                    var deleteRgResponse = m_ResourcesClient.ResourceGroups.BeginDeleting(rgName);
                    Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.Accepted, "BeginDeleting status was not Accepted.");
                }

                Assert.True(passed);
            }
        }

        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet
        /// Start VMScaleSet Instances
        /// Stop VMScaleSet Instance
        /// Restart VMScaleSet Instance
        /// Deallocate VMScaleSet Instance
        /// Delete VMScaleSet Instance
        /// Delete RG
        /// </summary>
        [Fact]
        public void TestVMScaleSetBatchOperations()
        {
            using (var context = UndoContext.Current)
            {
                context.Start();
                EnsureClientsInitialized();

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);

                // Create resource group
                string rgName = TestUtilities.GenerateName(TestPrefix) + 1;
                string storageAccountName = TestUtilities.GenerateName(TestPrefix);
                VirtualMachineScaleSet inputVMScaleSet;

                bool passed = false;
                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    VirtualMachineScaleSet vmScaleSet = CreateVMScaleSet_NoAsyncTracking(rgName, storageAccountOutput, imageRef, out inputVMScaleSet);

                    VirtualMachineScaleSetVMInstanceIDs virtualMachineScaleSetInstanceIDs = new VirtualMachineScaleSetVMInstanceIDs()
                    {
                        InstanceIDs = new List<string>() {"0", "1"}
                    };

                    var startOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginStartingInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(HttpStatusCode.Accepted, startOperationResponse.StatusCode);
                    ComputeLongRunningOperationResponse lroResponse = m_CrpClient.VirtualMachineScaleSets.StartInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    virtualMachineScaleSetInstanceIDs.InstanceIDs = new List<string>() { "0" };
                    var stopOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginPoweringOffInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(HttpStatusCode.Accepted, stopOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.PowerOffInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    virtualMachineScaleSetInstanceIDs.InstanceIDs = new List<string>() { "1" };
                    var restartOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginRestartingInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(HttpStatusCode.Accepted, restartOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.RestartInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deallocateOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginDeallocatingInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(HttpStatusCode.Accepted, deallocateOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSets.DeallocateInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deleteOperationResponse = m_CrpClient.VirtualMachineScaleSets.BeginDeletingInstances(rgName, vmScaleSet.Name, virtualMachineScaleSetInstanceIDs);
                    Assert.Equal(HttpStatusCode.Accepted, deleteOperationResponse.StatusCode);

                    passed = true;
                }
                finally
                {
                    // Cleanup the created resources. But don't wait since it takes too long, and it's not the purpose
                    // of the test to cover deletion. CSM does persistent retrying over all RG resources.
                    var deleteRgResponse = m_ResourcesClient.ResourceGroups.BeginDeleting(rgName);
                    Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.Accepted, "BeginDeleting status was not Accepted.");
                }

                Assert.True(passed);
            }
        }
    }
}