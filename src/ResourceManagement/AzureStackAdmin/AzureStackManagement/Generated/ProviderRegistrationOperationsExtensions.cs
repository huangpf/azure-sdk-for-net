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
    public static partial class ProviderRegistrationOperationsExtensions
    {
        /// <summary>
        /// Registers a resource provider manifest
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='parameters'>
        /// Required. Resource provider manifest definition
        /// </param>
        /// <returns>
        /// Result of the create or update of resource provider manifest
        /// </returns>
        public static ProviderRegistrationCreateOrUpdateResult CreateOrUpdate(this IProviderRegistrationOperations operations, string resourceGroupName, ProviderRegistrationCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderRegistrationOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Registers a resource provider manifest
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='parameters'>
        /// Required. Resource provider manifest definition
        /// </param>
        /// <returns>
        /// Result of the create or update of resource provider manifest
        /// </returns>
        public static Task<ProviderRegistrationCreateOrUpdateResult> CreateOrUpdateAsync(this IProviderRegistrationOperations operations, string resourceGroupName, ProviderRegistrationCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the resource provider registration
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Required. Resource provider manifest Id
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IProviderRegistrationOperations operations, string resourceGroupName, string providerregistrationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderRegistrationOperations)s).DeleteAsync(resourceGroupName, providerregistrationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the resource provider registration
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Required. Resource provider manifest Id
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IProviderRegistrationOperations operations, string resourceGroupName, string providerregistrationId)
        {
            return operations.DeleteAsync(resourceGroupName, providerregistrationId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the manifest registration for the specified manifest
        /// registration id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Required. Resource provider manifest registration Id
        /// </param>
        /// <returns>
        /// Get result of the resource provider manifest registration
        /// </returns>
        public static ProviderRegistrationGetResult Get(this IProviderRegistrationOperations operations, string resourceGroupName, string providerregistrationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderRegistrationOperations)s).GetAsync(resourceGroupName, providerregistrationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the manifest registration for the specified manifest
        /// registration id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Required. Resource provider manifest registration Id
        /// </param>
        /// <returns>
        /// Get result of the resource provider manifest registration
        /// </returns>
        public static Task<ProviderRegistrationGetResult> GetAsync(this IProviderRegistrationOperations operations, string resourceGroupName, string providerregistrationId)
        {
            return operations.GetAsync(resourceGroupName, providerregistrationId, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the registered provider manifest given a resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <returns>
        /// Result of the resource provider manifest list operation
        /// </returns>
        public static ProviderRegistrationListResult List(this IProviderRegistrationOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderRegistrationOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the registered provider manifest given a resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IProviderRegistrationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <returns>
        /// Result of the resource provider manifest list operation
        /// </returns>
        public static Task<ProviderRegistrationListResult> ListAsync(this IProviderRegistrationOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
    }
}
