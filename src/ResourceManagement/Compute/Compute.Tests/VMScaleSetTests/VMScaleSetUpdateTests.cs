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
    public class VMScaleSetUpdateTests : VMScaleSetTestsBase
    {
        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet
        /// ScaleOut VMScaleSet
        /// ScaleIn VMScaleSet
        /// Delete VMScaleSet
        /// Delete RG
        /// </summary>
        [Fact]
        public void TestVMScaleSetScalingOperations()
        {
            using (var context = UndoContext.Current)
            {
                context.Start();
                EnsureClientsInitialized();

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);
                // Create resource group
                var rgName = TestUtilities.GenerateName(TestPrefix);
                string storageAccountName = TestUtilities.GenerateName(TestPrefix);
                VirtualMachineScaleSet inputVMScaleSet;
                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    var deleteVMScaleSetResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, "VMScaleSetDoesNotExist");
                    Assert.True(deleteVMScaleSetResponse.Status == OperationStatus.Succeeded);

                    var vmScaleSet = CreateVMScaleSet(rgName, storageAccountOutput, imageRef, out inputVMScaleSet);

                    var getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    // Scale Out VMScaleSet
                    inputVMScaleSet.Sku.Capacity = 3;
                    UpdateVMScaleSet(rgName, inputVMScaleSet);

                    getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    // Scale In VMScaleSet
                    inputVMScaleSet.Sku.Capacity = 1;
                    UpdateVMScaleSet(rgName, inputVMScaleSet);

                    getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    var deleteResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, inputVMScaleSet.Name);
                    Assert.True(deleteResponse.Status != OperationStatus.Failed);
                }
                finally
                {
                    //Cleanup the created resources. But don't wait since it takes too long, and it's not the purpose
                    //of the test to cover deletion. CSM does persistent retrying over all RG resources.
                    var deleteRgResponse = m_ResourcesClient.ResourceGroups.BeginDeleting(rgName);
                    Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.Accepted, "BeginDeleting status was not Accepted.");
                }
            }
        }

        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet
        /// Update VMScaleSet
        /// Delete VMScaleSet
        /// Delete RG
        /// </summary>
        [Fact]
        public void TestVMScaleSetUpdateOperations()
        {
            using (var context = UndoContext.Current)
            {
                context.Start();
                EnsureClientsInitialized();

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);
                // Create resource group
                var rgName = TestUtilities.GenerateName(TestPrefix);
                string storageAccountName = TestUtilities.GenerateName(TestPrefix);
                VirtualMachineScaleSet inputVMScaleSet;
                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    var deleteVMScaleSetResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, "VMScaleSetDoesNotExist");
                    Assert.True(deleteVMScaleSetResponse.Status == OperationStatus.Succeeded);

                    var vmScaleSet = CreateVMScaleSet(rgName, storageAccountOutput, imageRef, out inputVMScaleSet);

                    var getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    inputVMScaleSet.Sku.Name = VirtualMachineSizeTypes.StandardA1;
                    UpdateVMScaleSet(rgName, inputVMScaleSet);

                    getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    var deleteResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, inputVMScaleSet.Name);
                    Assert.True(deleteResponse.Status != OperationStatus.Failed);
                }
                finally
                {
                    //Cleanup the created resources. But don't wait since it takes too long, and it's not the purpose
                    //of the test to cover deletion. CSM does persistent retrying over all RG resources.
                    var deleteRgResponse = m_ResourcesClient.ResourceGroups.BeginDeleting(rgName);
                    Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.Accepted, "BeginDeleting status was not Accepted.");
                }
            }
        }
    }
}
