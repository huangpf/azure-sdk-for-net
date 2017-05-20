﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch
{
    public partial class VirtualMachineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineConfiguration"/> class.
        /// </summary>
        /// <param name='imageReference'>A reference to the Azure Virtual Machines Marketplace image to use.</param>
        /// <param name='nodeAgentSkuId'>The SKU of Batch Node Agent to be provisioned on the compute node.</param>
        /// <param name='windowsConfiguration'>Windows operating system settings on the virtual machine. This property must not be specified if the ImageReference 
        /// property specifies a Linux OS image.</param>
        public VirtualMachineConfiguration(
            ImageReference imageReference,
            string nodeAgentSkuId,
            WindowsConfiguration windowsConfiguration = default(WindowsConfiguration)) : 
            this(nodeAgentSkuId, imageReference: imageReference, windowsConfiguration: windowsConfiguration)
        {
        }
    }
}
