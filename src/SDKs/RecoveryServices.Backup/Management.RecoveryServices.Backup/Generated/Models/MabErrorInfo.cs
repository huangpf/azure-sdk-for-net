// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MAB workload-specific error information.
    /// </summary>
    public partial class MabErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the MabErrorInfo class.
        /// </summary>
        public MabErrorInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MabErrorInfo class.
        /// </summary>
        /// <param name="errorString">Localized error string.</param>
        /// <param name="recommendations">List of localized
        /// recommendations.</param>
        public MabErrorInfo(string errorString = default(string), IList<string> recommendations = default(IList<string>))
        {
            ErrorString = errorString;
            Recommendations = recommendations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets localized error string.
        /// </summary>
        [JsonProperty(PropertyName = "errorString")]
        public string ErrorString { get; set; }

        /// <summary>
        /// Gets or sets list of localized recommendations.
        /// </summary>
        [JsonProperty(PropertyName = "recommendations")]
        public IList<string> Recommendations { get; set; }

    }
}
