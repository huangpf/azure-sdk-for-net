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

using Microsoft.Azure;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Test;
using System.Net;
using Xunit;

namespace Compute.Tests
{
    public class VMScaleSetVMOperationalTests : VMScaleSetVMTestsBase 
    {
        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet
        /// Get VMScaleSetVM Model View
        /// Get VMScaleSetVM Instance View
        /// List VMScaleSetVMs Model View
        /// List VMScaleSetVMs Instance View
        /// Start VMScaleSetVM
        /// Stop VMScaleSetVM
        /// Restart VMScaleSetVM
        /// Deallocate VMScaleSetVM
        /// Delete VMScaleSetVM
        /// Delete RG
        /// </summary>
        [Fact]
        public void TestVMScaleSetVMOperations()
        {
            using (var context = UndoContext.Current)
            {
                context.Start();
                EnsureClientsInitialized();

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);

                // Create resource group
                string rgName = TestUtilities.GenerateName(TestPrefix) + 1;
                string storageAccountName = TestUtilities.GenerateName(TestPrefix);
                const string instanceId = "0";
                VirtualMachineScaleSet inputVMScaleSet;

                bool passed = false;
                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    VirtualMachineScaleSet vmScaleSet = CreateVMScaleSet_NoAsyncTracking(rgName, storageAccountOutput, imageRef, out inputVMScaleSet);
                    
                    var getResponse = m_CrpClient.VirtualMachineScaleSetVMs.Get(rgName, vmScaleSet.Name, instanceId);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    Assert.True(getResponse.VirtualMachineScaleSetVM != null, "VMScaleSetVM not returned.");
                    VirtualMachineScaleSetVM vmScaleSetVMModel = GenerateVMScaleSetVMModel(vmScaleSet, instanceId);
                    ValidateVMScaleSetVM(vmScaleSetVMModel, getResponse.VirtualMachineScaleSetVM);

                    var getInstanceViewResponse = m_CrpClient.VirtualMachineScaleSetVMs.GetInstanceView(rgName, vmScaleSet.Name, instanceId);
                    Assert.True(getInstanceViewResponse.StatusCode == HttpStatusCode.OK);
                    Assert.True(getInstanceViewResponse.VirtualMachineScaleSetVMInstanceView != null, "VMScaleSetVM not returned.");
                    ValidateVMScaleSetVMInstanceView(getInstanceViewResponse.VirtualMachineScaleSetVMInstanceView);

                    var listParameters = new VirtualMachineScaleSetVMListParameters()
                    {
                        ResourceGroupName = rgName,
                        VirtualMachineScaleSetName = inputVMScaleSet.Name,
                        FilterExpression = "$filter=properties/latestModelApplied eq true"
                    };
                    var listResponse = m_CrpClient.VirtualMachineScaleSetVMs.List(listParameters);
                    Assert.True(listResponse.StatusCode == HttpStatusCode.OK);
                    Assert.False(listResponse.VirtualMachineScaleSetVMs == null, "VMScaleSetVMs not returned");
                    Assert.True(listResponse.VirtualMachineScaleSetVMs.Count == inputVMScaleSet.Sku.Capacity);

                    listParameters = new VirtualMachineScaleSetVMListParameters()
                    {
                        ResourceGroupName = rgName,
                        VirtualMachineScaleSetName = inputVMScaleSet.Name,
                        SelectExpression = "$select=instanceView",
                        ExpandExpression = "$expand=instanceView"
                    };
                    listResponse = m_CrpClient.VirtualMachineScaleSetVMs.List(listParameters);
                    Assert.True(listResponse.StatusCode == HttpStatusCode.OK);
                    Assert.False(listResponse.VirtualMachineScaleSetVMs == null, "VMScaleSetVMs not returned");
                    Assert.True(listResponse.VirtualMachineScaleSetVMs.Count == inputVMScaleSet.Sku.Capacity);
                    
                    var startOperationResponse = m_CrpClient.VirtualMachineScaleSetVMs.BeginStarting(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(HttpStatusCode.Accepted, startOperationResponse.StatusCode);
                    ComputeLongRunningOperationResponse lroResponse = m_CrpClient.VirtualMachineScaleSetVMs.Start(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var restartOperationResponse = m_CrpClient.VirtualMachineScaleSetVMs.BeginRestarting(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(HttpStatusCode.Accepted, restartOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSetVMs.Restart(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var stopOperationResponse = m_CrpClient.VirtualMachineScaleSetVMs.BeginPoweringOff(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(HttpStatusCode.Accepted, stopOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSetVMs.PowerOff(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deallocateOperationResponse = m_CrpClient.VirtualMachineScaleSetVMs.BeginDeallocating(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(HttpStatusCode.Accepted, deallocateOperationResponse.StatusCode);
                    lroResponse = m_CrpClient.VirtualMachineScaleSetVMs.Deallocate(rgName, vmScaleSet.Name, instanceId);
                    Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                    var deleteResponse = m_CrpClient.VirtualMachineScaleSetVMs.Delete(rgName, vmScaleSet.Name, instanceId);
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
    }
}