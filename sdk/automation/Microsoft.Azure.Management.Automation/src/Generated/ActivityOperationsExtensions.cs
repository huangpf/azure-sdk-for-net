// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActivityOperations.
    /// </summary>
    public static partial class ActivityOperationsExtensions
    {
            /// <summary>
            /// Retrieve the activity in the module identified by module name and activity
            /// name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            /// <param name='activityName'>
            /// The name of activity.
            /// </param>
            public static Activity Get(this IActivityOperations operations, string resourceGroupName, string automationAccountName, string moduleName, string activityName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, moduleName, activityName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the activity in the module identified by module name and activity
            /// name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            /// <param name='activityName'>
            /// The name of activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Activity> GetAsync(this IActivityOperations operations, string resourceGroupName, string automationAccountName, string moduleName, string activityName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, moduleName, activityName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of activities in the module identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            public static IPage<Activity> ListByModule(this IActivityOperations operations, string resourceGroupName, string automationAccountName, string moduleName)
            {
                return operations.ListByModuleAsync(resourceGroupName, automationAccountName, moduleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of activities in the module identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Activity>> ListByModuleAsync(this IActivityOperations operations, string resourceGroupName, string automationAccountName, string moduleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByModuleWithHttpMessagesAsync(resourceGroupName, automationAccountName, moduleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of activities in the module identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Activity> ListByModuleNext(this IActivityOperations operations, string nextPageLink)
            {
                return operations.ListByModuleNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of activities in the module identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/activityoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Activity>> ListByModuleNextAsync(this IActivityOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByModuleNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}