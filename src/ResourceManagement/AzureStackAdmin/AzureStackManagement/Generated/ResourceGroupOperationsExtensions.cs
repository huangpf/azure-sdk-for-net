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
using Microsoft.Azure;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class ResourceGroupOperationsExtensions
    {
        /// <summary>
        /// Creates or updates the resourcegroup
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Resource group creation or update parameters
        /// </param>
        /// <returns>
        /// Result of resource group create or update operation
        /// </returns>
        public static ResourceGroupCreateOrUpdateResult CreateOrUpdate(this IResourceGroupOperations operations, ResourceGroupCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).CreateOrUpdateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates or updates the resourcegroup
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Resource group creation or update parameters
        /// </param>
        /// <returns>
        /// Result of resource group create or update operation
        /// </returns>
        public static Task<ResourceGroupCreateOrUpdateResult> CreateOrUpdateAsync(this IResourceGroupOperations operations, ResourceGroupCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the given resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).DeleteAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the given resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.DeleteAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the resource group details for the given resource group name
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Result of the resource group get operation
        /// </returns>
        public static ResourceGroupGetResult Get(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).GetAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the resource group details for the given resource group name
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Result of the resource group get operation
        /// </returns>
        public static Task<ResourceGroupGetResult> GetAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.GetAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the resource group under the subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <returns>
        /// Result of the resource group list operation
        /// </returns>
        public static ResourceGroupListResult List(this IResourceGroupOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the resource group under the subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <returns>
        /// Result of the resource group list operation
        /// </returns>
        public static Task<ResourceGroupListResult> ListAsync(this IResourceGroupOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the next set of resource groups under the subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to get the next set of resource groups
        /// </param>
        /// <returns>
        /// Result of the resource group list operation
        /// </returns>
        public static ResourceGroupListResult ListNext(this IResourceGroupOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the next set of resource groups under the subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to get the next set of resource groups
        /// </param>
        /// <returns>
        /// Result of the resource group list operation
        /// </returns>
        public static Task<ResourceGroupListResult> ListNextAsync(this IResourceGroupOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the resources under the given resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Result of resources list operation
        /// </returns>
        public static ResourceGroupListResourcesResult ListResources(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).ListResourcesAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the resources under the given resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Result of resources list operation
        /// </returns>
        public static Task<ResourceGroupListResourcesResult> ListResourcesAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.ListResourcesAsync(resourceGroupName, CancellationToken.None);
        }
    }
}
