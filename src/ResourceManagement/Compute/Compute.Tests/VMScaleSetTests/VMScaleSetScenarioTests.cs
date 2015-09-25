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
using System.Linq;
using System.Net;
using Xunit;
using Hyak.Common;
using System.Collections.Generic;

namespace Compute.Tests
{
    public class VMScaleSetScenarioTests : VMScaleSetTestsBase
    {
        /// <summary>
        /// Covers following Operations:
        /// Create RG
        /// Create Storage Account
        /// Create Network Resources
        /// Create VMScaleSet with extension
        /// Get VMScaleSet Model View
        /// List VMScaleSets in a RG
        /// List Available Skus
        /// Delete VMScaleSet
        /// Delete RG
        /// </summary>
        [Fact]
        [Trait("Name", "TestVMScaleSetScenarioOperations")]
        public void TestVMScaleSetScenarioOperations()
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

                VirtualMachineScaleSetExtensionProfile extensionProfile = new VirtualMachineScaleSetExtensionProfile()
                {
                    Extensions = new List<VirtualMachineScaleSetExtension>()
                    {
                        GetTestVMSSVMExtension(),
                    }
                };

                try
                {
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    var deleteVMScaleSetResponse = m_CrpClient.VirtualMachineScaleSets.Delete(rgName, "VMScaleSetDoesNotExist");
                    Assert.True(deleteVMScaleSetResponse.Status == OperationStatus.Succeeded);

                    var vmScaleSet = CreateVMScaleSet_NoAsyncTracking(rgName, storageAccountOutput, imageRef, out inputVMScaleSet, extensionProfile);

                    var getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, vmScaleSet.Name);
                    Assert.True(getResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, getResponse.VirtualMachineScaleSet);

                    var listResponse = m_CrpClient.VirtualMachineScaleSets.List(rgName);
                    Assert.True(listResponse.StatusCode == HttpStatusCode.OK);
                    ValidateVMScaleSet(inputVMScaleSet, listResponse.VirtualMachineScaleSets.FirstOrDefault(x => x.Name == inputVMScaleSet.Name));

                    var listSkusResponse = m_CrpClient.VirtualMachineScaleSets.ListSkus(rgName, inputVMScaleSet.Name);
                    Assert.True(listSkusResponse.StatusCode == HttpStatusCode.OK);
                    Assert.False(listSkusResponse.VirtualMachineScaleSetAvailableSkus == null);
                    Assert.False(listSkusResponse.VirtualMachineScaleSetAvailableSkus.Count == 0);

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
