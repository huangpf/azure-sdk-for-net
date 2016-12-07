// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Azure;
    using Management;
    using DataLake;
    using Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A WebHDFS exception thrown when an unexpected error occurs during an
    /// operation. Thrown when a 500 error response code is returned (Internal
    /// server error).
    /// </summary>
    [Newtonsoft.Json.JsonObject("RuntimeException")]
    public partial class AdlsRuntimeException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsRuntimeException class.
        /// </summary>
        public AdlsRuntimeException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsRuntimeException class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsRuntimeException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}

