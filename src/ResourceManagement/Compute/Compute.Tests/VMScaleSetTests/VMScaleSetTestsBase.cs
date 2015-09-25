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

using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;
using Microsoft.Azure.Test;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using Xunit;

namespace Compute.Tests
{
    public class VMScaleSetTestsBase : VMTestBase
    {
        protected VirtualMachineScaleSetExtension GetTestVMSSVMExtension()
        {
            var vmExtension = new VirtualMachineScaleSetExtension
            {
                Name = "vmssext01",
                Location = ComputeManagementTestUtilities.DefaultLocation,
                Type = null,
                Tags = null,
                Id = null,
                Publisher = "Microsoft.Compute",
                ExtensionType = "VMAccessAgent",
                TypeHandlerVersion = "2.0",
                AutoUpgradeMinorVersion = true,
                Settings = "{}",
                ProtectedSettings = "{}"
            };

            return vmExtension;
        }
        protected VirtualMachineScaleSet CreateDefaultVMScaleSetInput(string rgName, string storageAccountName, ImageReference imageRef, string subnetId)
        {
            // Generate Container name to hold disk VHds
            string containerName = TestUtilities.GenerateName(TestPrefix);
            var vhdContainer = "https://" + storageAccountName + ".blob.core.windows.net/" + containerName;
    
            return new VirtualMachineScaleSet()
            {
                Name = TestUtilities.GenerateName("vmss"),
                Location = m_location,
                Tags = new Dictionary<string, string>() { { "RG", "rg" }, { "testTag", "1" } },
                Type = "Microsoft.Compute/virtualMachineScaleSets",
                Sku = new Sku()
                {
                    Capacity = 2,
                    Name = VirtualMachineSizeTypes.StandardA0,
                },
                UpgradePolicy = new UpgradePolicy()
                {
                    Mode = UpgradeMode.Automatic
                },
                VirtualMachineProfile = new VirtualMachineScaleSetVMProfile()
                {
                    StorageProfile = new VirtualMachineScaleSetStorageProfile()
                    {
                        ImageReference = imageRef,
                        OSDisk = new VirtualMachineScaleSetOSDisk
                        {
                            Caching = CachingTypes.None,
                            CreateOption = DiskCreateOptionTypes.FromImage,
                            Name = "test",
                            VirtualHardDiskContainers = new List<string>{ vhdContainer }
                        },
                    },
                    OSProfile = new VirtualMachineScaleSetOSProfile()
                    {
                        ComputerNamePrefix = "test",
                        AdminUsername = "Foo12",
                        AdminPassword = "BaR@123" + rgName,
                        CustomData = Convert.ToBase64String(Encoding.UTF8.GetBytes("Custom data"))
                    },
                    NetworkProfile = new VirtualMachineScaleSetNetworkProfile()
                    {
                        NetworkInterfaceConfigurations = new List<VirtualMachineScaleSetNetworkConfiguration>()
                        {
                            new VirtualMachineScaleSetNetworkConfiguration()
                            {
                                Name = TestUtilities.GenerateName("vmsstestnetconfig"),
                                Primary = true,
                                IPConfigurations = new List<VirtualMachineScaleSetIPConfiguration>
                                {
                                    new VirtualMachineScaleSetIPConfiguration()
                                    {
                                        Name = TestUtilities.GenerateName("vmsstestnetconfig"),
                                        Subnet = new ApiEntityReference()
                                        {
                                            ReferenceUri = subnetId
                                        }
                                        
                                    }
                                }
                            }
                        }
                    },
                    ExtensionProfile = new VirtualMachineScaleSetExtensionProfile(),
                }
            };
        }

        protected VirtualMachineScaleSet CreateVMScaleSet_NoAsyncTracking(
            string rgName, 
            StorageAccount storageAccount, 
            ImageReference imageRef,
            out VirtualMachineScaleSet inputVMScaleSet,
            VirtualMachineScaleSetExtensionProfile extensionProfile = null,
            Action<VirtualMachineScaleSet> vmScaleSetCustomizer = null,
            bool createWithPublicIpAddress = false)
        {
            try
            {
                var createOrUpdateResponse = CreateVMScaleSetAndGetOperationResponse(rgName, 
                                                                                     storageAccount, 
                                                                                     imageRef, 
                                                                                     out inputVMScaleSet, 
                                                                                     extensionProfile,
                                                                                     vmScaleSetCustomizer);

                var operationUri = new Uri(createOrUpdateResponse.AzureAsyncOperation);
                string operationId = operationUri.Segments.LastOrDefault();
                var lroResponse = m_CrpClient.GetLongRunningOperationStatus(createOrUpdateResponse.AzureAsyncOperation.ToString());
                ValidateLROResponse(lroResponse, operationId);

                var getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, inputVMScaleSet.Name);
                Assert.True(getResponse.StatusCode == HttpStatusCode.OK);

                return getResponse.VirtualMachineScaleSet;
            }
            catch
            {
                var deleteRgResponse = m_ResourcesClient.ResourceGroups.Delete(rgName);
                Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.OK);
                throw;
            }
        }

        protected VirtualMachineScaleSet CreateVMScaleSet(
            string rgName, 
            StorageAccount storageAccount, 
            ImageReference imageRef,
            out VirtualMachineScaleSet inputVMScaleSet,
            VirtualMachineScaleSetExtensionProfile extensionProfile = null,
            Action<VirtualMachineScaleSet> vmScaleSetCustomizer = null,
            bool createWithPublicIpAddress = false)
        {
            try
            {
                var createOrUpdateResponse = CreateVMScaleSetAndGetOperationResponse(rgName, storageAccount, imageRef, out inputVMScaleSet, extensionProfile,
                    vmScaleSetCustomizer);
                Assert.Equal(HttpStatusCode.Created, createOrUpdateResponse.StatusCode);

                var lroResponse = m_CrpClient.VirtualMachineScaleSets.CreateOrUpdate(rgName, inputVMScaleSet);
                Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);

                var getResponse = m_CrpClient.VirtualMachineScaleSets.Get(rgName, inputVMScaleSet.Name);
                Assert.True(getResponse.StatusCode == HttpStatusCode.OK);

                return getResponse.VirtualMachineScaleSet;
            }
            catch
            {
                var deleteRgResponse = m_ResourcesClient.ResourceGroups.Delete(rgName);
                Assert.True(deleteRgResponse.StatusCode == HttpStatusCode.OK);
                throw;
            }
        }

        protected void UpdateVMScaleSet(string rgName, VirtualMachineScaleSet inputVMScaleSet)
        {
            var createOrUpdateResponse = m_CrpClient.VirtualMachineScaleSets.BeginCreatingOrUpdating(rgName, inputVMScaleSet);
            Assert.True(createOrUpdateResponse.StatusCode == HttpStatusCode.OK);

            var lroResponse = m_CrpClient.VirtualMachineScaleSets.CreateOrUpdate(rgName, inputVMScaleSet);
            Assert.Equal(ComputeOperationStatus.Succeeded, lroResponse.Status);
        }

        private VirtualMachineScaleSetCreateOrUpdateResponse CreateVMScaleSetAndGetOperationResponse(
            string rgName,
            StorageAccount storageAccount,
            ImageReference imageRef,
            out VirtualMachineScaleSet inputVMScaleSet,
            VirtualMachineScaleSetExtensionProfile extensionProfile = null,
            Action<VirtualMachineScaleSet> vmScaleSetCustomizer = null,
            bool createWithPublicIpAddress = false)
        {
            // Create the resource Group, it might have been already created during StorageAccount creation.
            var resourceGroup = m_ResourcesClient.ResourceGroups.CreateOrUpdate(
                rgName,
                new ResourceGroup
                {
                    Location = m_location
                });

            PublicIpAddressGetResponse getPublicIpAddressResponse = createWithPublicIpAddress ? null : CreatePublicIP(rgName);

            SubnetGetResponse subnetResponse = CreateVNET(rgName);

            NetworkInterfaceGetResponse nicResponse = CreateNIC(
                rgName,
                subnetResponse.Subnet,
                getPublicIpAddressResponse != null ? getPublicIpAddressResponse.PublicIpAddress : null);

            inputVMScaleSet = CreateDefaultVMScaleSetInput(rgName, storageAccount.Name, imageRef, subnetResponse.Subnet.Id);
            if (vmScaleSetCustomizer != null)
            {
                vmScaleSetCustomizer(inputVMScaleSet);
            }

            inputVMScaleSet.VirtualMachineProfile.ExtensionProfile = extensionProfile;

            var createOrUpdateResponse = m_CrpClient.VirtualMachineScaleSets.BeginCreatingOrUpdating(
                 rgName, inputVMScaleSet);

            Assert.True(createOrUpdateResponse.StatusCode == HttpStatusCode.Created);

            Assert.True(createOrUpdateResponse.VirtualMachineScaleSet.Name == inputVMScaleSet.Name);
            Assert.True(createOrUpdateResponse.VirtualMachineScaleSet.Location == inputVMScaleSet.Location.ToLower().Replace(" ", "") || createOrUpdateResponse.VirtualMachineScaleSet.Location.ToLower() == inputVMScaleSet.Location.ToLower());

            ValidateVMScaleSet(inputVMScaleSet, createOrUpdateResponse.VirtualMachineScaleSet);

            return createOrUpdateResponse;
        }

        protected void ValidateVMScaleSet(VirtualMachineScaleSet vmScaleSet, VirtualMachineScaleSet vmScaleSetOut)
        {
            Assert.True(!string.IsNullOrEmpty(vmScaleSetOut.ProvisioningState));

            Assert.True(vmScaleSetOut.Sku.Name
                     == vmScaleSet.Sku.Name);

            Assert.NotNull(vmScaleSetOut.VirtualMachineProfile.StorageProfile.OSDisk);

            Assert.True(vmScaleSetOut.VirtualMachineProfile.StorageProfile.OSDisk.Name
                     == vmScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.Name);

            if(vmScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.SourceImage != null)
            {
                Assert.True(vmScaleSetOut.VirtualMachineProfile.StorageProfile.OSDisk.SourceImage.Uri
                            == vmScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.SourceImage.Uri);
            }

            Assert.True(vmScaleSetOut.VirtualMachineProfile.StorageProfile.OSDisk.Caching
                     == vmScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.Caching);

            if (vmScaleSet.VirtualMachineProfile.OSProfile.Secrets != null &&
               vmScaleSet.VirtualMachineProfile.OSProfile.Secrets.Any())
            {
                foreach (var secret in vmScaleSet.VirtualMachineProfile.OSProfile.Secrets)
                {
                    Assert.NotNull(secret.VaultCertificates);
                    var secretOut = vmScaleSetOut.VirtualMachineProfile.OSProfile.Secrets.FirstOrDefault(s => string.Equals(secret.SourceVault.ReferenceUri, s.SourceVault.ReferenceUri));
                    Assert.NotNull(secretOut);

                    // Disabling resharper null-ref check as it doesn't seem to understand the not-null assert above.
                    // ReSharper disable PossibleNullReferenceException

                    Assert.NotNull(secretOut.VaultCertificates);
                    var VaultCertComparer = new VaultCertComparer();
                    Assert.True(secretOut.VaultCertificates.SequenceEqual(secret.VaultCertificates, VaultCertComparer));

                    // ReSharper enable PossibleNullReferenceException
                }
            }

            if (vmScaleSet.VirtualMachineProfile.ExtensionProfile != null &&
                vmScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.Any())
            {
                foreach (var vmExtension in vmScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions)
                {
                    var vmExt = vmScaleSetOut.VirtualMachineProfile.ExtensionProfile.Extensions.FirstOrDefault(s => String.Compare(s.Name, vmExtension.Name, StringComparison.InvariantCultureIgnoreCase) == 0);
                    Assert.NotNull(vmExt);
                }
            }
        }
    }
}
