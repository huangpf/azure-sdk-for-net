// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Server : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="kind">Kind of sql server.  This is metadata used for
        /// the Azure portal experience.</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of the server.</param>
        /// <param name="version">The version of the server. Possible values
        /// include: '2.0', '12.0'</param>
        /// <param name="administratorLogin">Administrator username for the
        /// server. Can only be specified when the server is being created (and
        /// is required for creation).</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for server creation).</param>
        /// <param name="externalAdministratorSid">The ID of the Active Azure
        /// Directory object with admin permissions on this server. Legacy
        /// parameter, always null. To check for Active Directory admin, query
        /// .../servers/{serverName}/administrators.</param>
        /// <param name="externalAdministratorLogin">The display name of the
        /// Azure Active Directory object with admin permissions on this
        /// server. Legacy parameter, always null. To check for Active
        /// Directory admin, query
        /// .../servers/{serverName}/administrators</param>
        /// <param name="state">The state of the server. Possible values
        /// include: 'Ready', 'Disabled'</param>
        public Server(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string fullyQualifiedDomainName = default(string), string version = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), System.Guid? externalAdministratorSid = default(System.Guid?), string externalAdministratorLogin = default(string), ServerState? state = default(ServerState?))
            : base(location, id, name, type, tags)
        {
            Kind = kind;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Version = version;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            ExternalAdministratorSid = externalAdministratorSid;
            ExternalAdministratorLogin = externalAdministratorLogin;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets kind of sql server.  This is metadata used for the Azure
        /// portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets or sets the version of the server. Possible values include:
        /// '2.0', '12.0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets administrator username for the server. Can only be
        /// specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for server
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets the ID of the Active Azure Directory object with admin
        /// permissions on this server. Legacy parameter, always null. To check
        /// for Active Directory admin, query
        /// .../servers/{serverName}/administrators.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalAdministratorSid")]
        public System.Guid? ExternalAdministratorSid { get; private set; }

        /// <summary>
        /// Gets the display name of the Azure Active Directory object with
        /// admin permissions on this server. Legacy parameter, always null. To
        /// check for Active Directory admin, query
        /// .../servers/{serverName}/administrators
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalAdministratorLogin")]
        public string ExternalAdministratorLogin { get; private set; }

        /// <summary>
        /// Gets the state of the server. Possible values include: 'Ready',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public ServerState? State { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
