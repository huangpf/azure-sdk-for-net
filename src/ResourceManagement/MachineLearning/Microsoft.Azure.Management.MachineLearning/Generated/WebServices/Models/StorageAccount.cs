// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Access information for a storage account.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="name">Specifies the name of the storage
        /// account.</param>
        /// <param name="key">Specifies the key used to access the storage
        /// account.</param>
        public StorageAccount(string name = default(string), string key = default(string))
        {
            Name = name;
            Key = key;
        }

        /// <summary>
        /// Gets or sets specifies the name of the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies the key used to access the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

    }
}
