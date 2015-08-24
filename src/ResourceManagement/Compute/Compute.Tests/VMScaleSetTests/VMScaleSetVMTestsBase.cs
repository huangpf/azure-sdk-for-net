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
    public class VMScaleSetVMTestsBase : VMScaleSetTestsBase
    {
        protected void ValidateVMScaleSetVM(VirtualMachineScaleSetVM vmScaleSetVM, VirtualMachineScaleSetVM vmScaleSetVMOut)
        {
            Assert.True(!string.IsNullOrEmpty(vmScaleSetVMOut.ProvisioningState));

            Assert.True(vmScaleSetVM.Sku.Name
                == vmScaleSetVMOut.Sku.Name);
            
            Assert.NotNull(vmScaleSetVMOut.StorageProfile.OSDisk);

            if (vmScaleSetVM.StorageProfile.OSDisk.SourceImage != null)
            {
                Assert.True(vmScaleSetVMOut.StorageProfile.OSDisk.SourceImage.Uri
                            == vmScaleSetVM.StorageProfile.OSDisk.SourceImage.Uri);
            }

            Assert.True(vmScaleSetVMOut.StorageProfile.OSDisk.Caching
                     == vmScaleSetVM.StorageProfile.OSDisk.Caching);

            if (vmScaleSetVM.OSProfile.Secrets != null &&
               vmScaleSetVM.OSProfile.Secrets.Any())
            {
                foreach (var secret in vmScaleSetVM.OSProfile.Secrets)
                {
                    Assert.NotNull(secret.VaultCertificates);
                    var secretOut = vmScaleSetVMOut.OSProfile.Secrets.FirstOrDefault(s => string.Equals(secret.SourceVault.ReferenceUri, s.SourceVault.ReferenceUri));
                    Assert.NotNull(secretOut);

                    // Disabling resharper null-ref check as it doesn't seem to understand the not-null assert above.
                    // ReSharper disable PossibleNullReferenceException

                    Assert.NotNull(secretOut.VaultCertificates);
                    var VaultCertComparer = new VaultCertComparer();
                    Assert.True(secretOut.VaultCertificates.SequenceEqual(secret.VaultCertificates, VaultCertComparer));

                    // ReSharper enable PossibleNullReferenceException
                }
            }
        }

        protected void ValidateVMScaleSetVMInstanceView(VirtualMachineScaleSetVMInstanceView vmScaleSetVMInstanceView)
        {
            Assert.NotNull(vmScaleSetVMInstanceView);
            Assert.True(vmScaleSetVMInstanceView.Statuses.Any(s => !string.IsNullOrEmpty(s.Code)));

            var instanceView = vmScaleSetVMInstanceView;
            Assert.NotNull(instanceView.Disks);
            Assert.True(instanceView.Disks.Any());

            DiskInstanceView diskInstanceView = instanceView.Disks.First();
            Assert.NotNull(diskInstanceView);
            Assert.NotNull(diskInstanceView.Statuses[0].DisplayStatus);
            Assert.NotNull(diskInstanceView.Statuses[0].Code);
            Assert.NotNull(diskInstanceView.Statuses[0].Level);
        }

        protected VirtualMachineScaleSetVM GenerateVMScaleSetVMModel(VirtualMachineScaleSet inputVMScaleSet, string instanceId)
        {
            VirtualMachineScaleSetVM expectedVirtualMachineScaleSetVM = new VirtualMachineScaleSetVM()
            {
                InstanceId = instanceId,
                Sku = new Sku()
                {
                    Name = inputVMScaleSet.Sku.Name
                },
                OSProfile = new OSProfile()
                {
                    AdminPassword = inputVMScaleSet.VirtualMachineProfile.OSProfile.AdminPassword,
                    AdminUsername = inputVMScaleSet.VirtualMachineProfile.OSProfile.AdminUsername,
                    CustomData = inputVMScaleSet.VirtualMachineProfile.OSProfile.CustomData,
                    ComputerName = inputVMScaleSet.VirtualMachineProfile.OSProfile.ComputerNamePrefix + "-" + instanceId
                },
                StorageProfile = new StorageProfile()
                {
                    ImageReference = inputVMScaleSet.VirtualMachineProfile.StorageProfile.ImageReference,
                    OSDisk = new OSDisk()
                    {
                        Name = inputVMScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.Name,
                        Caching = inputVMScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.Caching,
                        CreateOption = inputVMScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.CreateOption,
                        OperatingSystemType = inputVMScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.OperatingSystemType,
                        SourceImage = inputVMScaleSet.VirtualMachineProfile.StorageProfile.OSDisk.SourceImage,
                    }
                },
            };

            return expectedVirtualMachineScaleSetVM;
        }
    }
}
