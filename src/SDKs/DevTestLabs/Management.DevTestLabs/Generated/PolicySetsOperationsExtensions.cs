// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PolicySetsOperations.
    /// </summary>
    public static partial class PolicySetsOperationsExtensions
    {
            /// <summary>
            /// Evaluates lab policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the policy set.
            /// </param>
            /// <param name='evaluatePoliciesRequest'>
            /// Request body for evaluating a policy set.
            /// </param>
            public static EvaluatePoliciesResponse EvaluatePolicies(this IPolicySetsOperations operations, string labName, string name, EvaluatePoliciesRequest evaluatePoliciesRequest)
            {
                return Task.Factory.StartNew(s => ((IPolicySetsOperations)s).EvaluatePoliciesAsync(labName, name, evaluatePoliciesRequest), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Evaluates lab policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the policy set.
            /// </param>
            /// <param name='evaluatePoliciesRequest'>
            /// Request body for evaluating a policy set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EvaluatePoliciesResponse> EvaluatePoliciesAsync(this IPolicySetsOperations operations, string labName, string name, EvaluatePoliciesRequest evaluatePoliciesRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EvaluatePoliciesWithHttpMessagesAsync(labName, name, evaluatePoliciesRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
