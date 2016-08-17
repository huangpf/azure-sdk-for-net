// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The key operation result
    /// </summary>
    public partial class KeyOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the KeyOperationResult class.
        /// </summary>
        public KeyOperationResult() { }

        /// <summary>
        /// Initializes a new instance of the KeyOperationResult class.
        /// </summary>
        /// <param name="kid">Key identifier</param>
        public KeyOperationResult(string kid = default(string), byte[] result = default(byte[]))
        {
            Kid = kid;
            Result = result;
        }

        /// <summary>
        /// Gets key identifier
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; private set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "value")]
        public byte[] Result { get; private set; }

    }
}
