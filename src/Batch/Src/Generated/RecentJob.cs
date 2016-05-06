//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about the most recent job under a job schedule.
    /// </summary>
    public partial class RecentJob : IPropertyMetadata
    {
        private readonly string id;
        private readonly string url;

        #region Constructors

        internal RecentJob(Models.RecentJob protocolObject)
        {
            this.id = protocolObject.Id;
            this.url = protocolObject.Url;
        }

        #endregion Constructors

        #region RecentJob

        /// <summary>
        /// Gets the id of the job.
        /// </summary>
        public string Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// Gets the URL of the job.
        /// </summary>
        public string Url
        {
            get { return this.url; }
        }

        #endregion // RecentJob

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}