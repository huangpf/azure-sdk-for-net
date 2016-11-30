// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Cross-Origin Resource Sharing (CORS) settings for the web app.
    /// </summary>
    public partial class CorsSettings
    {
        /// <summary>
        /// Initializes a new instance of the CorsSettings class.
        /// </summary>
        public CorsSettings() { }

        /// <summary>
        /// Initializes a new instance of the CorsSettings class.
        /// </summary>
        public CorsSettings(IList<string> allowedOrigins = default(IList<string>))
        {
            AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// Gets or sets the list of origins that should be allowed to make
        /// cross-origin
        /// calls (for example: http://example.com:12345). Use "*"
        /// to allow all.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

    }
}
