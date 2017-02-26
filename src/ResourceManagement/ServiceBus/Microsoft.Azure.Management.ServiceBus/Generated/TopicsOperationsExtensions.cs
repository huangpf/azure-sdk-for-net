// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TopicsOperations.
    /// </summary>
    public static partial class TopicsOperationsExtensions
    {
            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static IPage<TopicResource> ListAll(this ITopicsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListAllAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TopicResource>> ListAllAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a topic in the specified namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639409.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a topic resource.
            /// </param>
            public static TopicResource CreateOrUpdate(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, TopicCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, topicName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a topic in the specified namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639409.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a topic resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TopicResource> CreateOrUpdateAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, TopicCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a topic from the specified namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639404.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The name of the topic to delete.
            /// </param>
            public static void Delete(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a topic from the specified namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639404.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The name of the topic to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639399.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            public static TopicResource Get(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639399.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TopicResource> GetAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an authorizatio rule for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720678.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an authorizatio rule for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720678.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720676.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720676.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a topic authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static void DeleteAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a topic authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720677.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static ResourceListKeys ListKeys(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720677.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates primary or secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720679.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            public static ResourceListKeys RegenerateKeys(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, RegenerateKeysParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates primary or secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720679.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> RegenerateKeysAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, RegenerateKeysParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TopicResource> ListAllNext(this ITopicsOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
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
            public static async Task<IPage<TopicResource>> ListAllNextAsync(this ITopicsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this ITopicsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this ITopicsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

