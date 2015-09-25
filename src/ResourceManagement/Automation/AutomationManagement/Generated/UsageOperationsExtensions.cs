// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class UsageOperationsExtensions
    {
        /// <summary>
        /// Retrieve the usage for the account id.  (see
        /// http://aka.ms/azureautomationsdk/usageoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IUsageOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the get usage operation.
        /// </returns>
        public static UsageListResponse List(this IUsageOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the usage for the account id.  (see
        /// http://aka.ms/azureautomationsdk/usageoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IUsageOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the get usage operation.
        /// </returns>
        public static Task<UsageListResponse> ListAsync(this IUsageOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
    }
}
