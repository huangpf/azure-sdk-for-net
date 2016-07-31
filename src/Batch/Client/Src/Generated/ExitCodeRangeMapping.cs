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
    /// A range of exit codes and how the Batch service should respond if a task exits with an exit code within that range.
    /// </summary>
    public partial class ExitCodeRangeMapping : ITransportObjectProvider<Models.ExitCodeRangeMapping>, IPropertyMetadata
    {
        private readonly int end;
        private readonly ExitOptions exitOptions;
        private readonly int start;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ExitCodeRangeMapping"/> class.
        /// </summary>
        /// <param name='start'>The first exit code in the range.</param>
        /// <param name='end'>The last exit code in the range.</param>
        /// <param name='exitOptions'>An <see cref="ExitOptions" /> specifying how the Batch service should respond if the task exits with an exit 
        /// code in the range <see cref="Start"/> to <see cref="End"/>.</param>
        public ExitCodeRangeMapping(
            int start,
            int end,
            ExitOptions exitOptions)
        {
            this.start = start;
            this.end = end;
            this.exitOptions = exitOptions;
        }

        internal ExitCodeRangeMapping(Models.ExitCodeRangeMapping protocolObject)
        {
            this.end = protocolObject.End;
            this.exitOptions = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExitOptions, o => new ExitOptions(o).Freeze());
            this.start = protocolObject.Start;
        }

        #endregion Constructors

        #region ExitCodeRangeMapping

        /// <summary>
        /// Gets the last exit code in the range.
        /// </summary>
        public int End
        {
            get { return this.end; }
        }

        /// <summary>
        /// Gets an <see cref="ExitOptions" /> specifying how the Batch service should respond if the task exits with an 
        /// exit code in the range <see cref="Start"/> to <see cref="End"/>.
        /// </summary>
        public ExitOptions ExitOptions
        {
            get { return this.exitOptions; }
        }

        /// <summary>
        /// Gets the first exit code in the range.
        /// </summary>
        public int Start
        {
            get { return this.start; }
        }

        #endregion // ExitCodeRangeMapping

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

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ExitCodeRangeMapping ITransportObjectProvider<Models.ExitCodeRangeMapping>.GetTransportObject()
        {
            Models.ExitCodeRangeMapping result = new Models.ExitCodeRangeMapping()
            {
                End = this.End,
                ExitOptions = UtilitiesInternal.CreateObjectWithNullCheck(this.ExitOptions, (o) => o.GetTransportObject()),
                Start = this.Start,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ExitCodeRangeMapping> ConvertFromProtocolCollection(IEnumerable<Models.ExitCodeRangeMapping> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitCodeRangeMapping> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitCodeRangeMapping(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ExitCodeRangeMapping> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ExitCodeRangeMapping> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitCodeRangeMapping> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitCodeRangeMapping(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ExitCodeRangeMapping> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ExitCodeRangeMapping> protoCollection)
        {
            IReadOnlyList<ExitCodeRangeMapping> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ExitCodeRangeMapping(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}