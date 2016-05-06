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
    /// An Azure Batch task to add.
    /// </summary>
    public partial class TaskAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        public TaskAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        public TaskAddParameter(string id, string commandLine, string displayName = default(string), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), AffinityInformation affinityInfo = default(AffinityInformation), TaskConstraints constraints = default(TaskConstraints), bool? runElevated = default(bool?), MultiInstanceSettings multiInstanceSettings = default(MultiInstanceSettings), TaskDependencies dependsOn = default(TaskDependencies))
        {
            Id = id;
            DisplayName = displayName;
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            RunElevated = runElevated;
            MultiInstanceSettings = multiInstanceSettings;
            DependsOn = dependsOn;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the task within the
        /// job. The id can contain any combination of alphanumeric
        /// characters including hyphens and underscores, and cannot contain
        /// more than 64 characters.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a display name for the task.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the command line of the task. For multi-instance
        /// tasks, the command line is executed on the primary subtask after
        /// all the subtasks have finished executing the coordianation
        /// command line.
        /// </summary>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that Batch will download to the
        /// compute node before running the command line. For multi-instance
        /// tasks, the resource files will only be downloaded to the compute
        /// node on which the primary subtask is executed.
        /// </summary>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service
        /// to select a compute node on which to start the new task.
        /// </summary>
        [JsonProperty(PropertyName = "affinityInfo")]
        public AffinityInformation AffinityInfo { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        [JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Gets or sets information about how to run the multi-instance task.
        /// </summary>
        [JsonProperty(PropertyName = "multiInstanceSettings")]
        public MultiInstanceSettings MultiInstanceSettings { get; set; }

        /// <summary>
        /// Gets or sets any dependencies this task has.
        /// </summary>
        [JsonProperty(PropertyName = "dependsOn")]
        public TaskDependencies DependsOn { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (CommandLine == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommandLine");
            }
            if (this.MultiInstanceSettings != null)
            {
                this.MultiInstanceSettings.Validate();
            }
        }
    }
}
