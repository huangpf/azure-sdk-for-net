// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// How the Batch service should respond to a particular exit condition.
    /// </summary>
    public partial class ExitOptions
    {
        /// <summary>
        /// Initializes a new instance of the ExitOptions class.
        /// </summary>
        public ExitOptions() { }

        /// <summary>
        /// Initializes a new instance of the ExitOptions class.
        /// </summary>
        /// <param name="jobAction">An action to take on the job containing the task, if the task completes with the given exit condition and the job’s onTaskFailed property is 'performexitoptionsjobaction'. Possible values include: 'none', 'disable', 'terminate'</param>
        public ExitOptions(JobAction? jobAction = default(JobAction?))
        {
            JobAction = jobAction;
        }

        /// <summary>
        /// Gets or sets an action to take on the job containing the task, if
        /// the task completes with the given exit condition and the job’s
        /// onTaskFailed property is 'performexitoptionsjobaction'. Possible
        /// values include: 'none', 'disable', 'terminate'
        /// </summary>
        [JsonProperty(PropertyName = "jobAction")]
        public JobAction? JobAction { get; set; }

    }
}
