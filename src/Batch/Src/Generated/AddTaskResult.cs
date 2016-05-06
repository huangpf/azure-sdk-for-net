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
    /// Result for a single task added as part of a collection of tasks.
    /// </summary>
    public partial class AddTaskResult : IPropertyMetadata
    {
        private readonly BatchError error;
        private readonly string eTag;
        private readonly DateTime? lastModified;
        private readonly string location;
        private readonly Common.AddTaskStatus status;
        private readonly string taskId;

        #region Constructors

        internal AddTaskResult(Models.TaskAddResult protocolObject)
        {
            this.error = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Error, o => new BatchError(o).Freeze());
            this.eTag = protocolObject.ETag;
            this.lastModified = protocolObject.LastModified;
            this.location = protocolObject.Location;
            this.status = UtilitiesInternal.MapEnum<Common.AddTaskStatus>(protocolObject.Status);
            this.taskId = protocolObject.TaskId;
        }

        #endregion Constructors

        #region AddTaskResult

        /// <summary>
        /// Gets the error caught while attempting to add the task.
        /// </summary>
        public BatchError Error
        {
            get { return this.error; }
        }

        /// <summary>
        /// Gets an ETag associated with a successfully added task.
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
        }

        /// <summary>
        /// Gets the last modified time associated with a successfully added task.
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.lastModified; }
        }

        /// <summary>
        /// Gets the URL of a successfully added task.
        /// </summary>
        public string Location
        {
            get { return this.location; }
        }

        /// <summary>
        /// Gets the status of the add task request.
        /// </summary>
        public Common.AddTaskStatus Status
        {
            get { return this.status; }
        }

        /// <summary>
        /// Gets the id of the task which this result applies to.
        /// </summary>
        public string TaskId
        {
            get { return this.taskId; }
        }

        #endregion // AddTaskResult

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