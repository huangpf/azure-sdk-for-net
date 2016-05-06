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
    /// Represents a certificate object of the Azure Batch service.
    /// </summary>
    public partial class CertificateReference : ITransportObjectProvider<Models.CertificateReference>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<Common.CertStoreLocation?> StoreLocationProperty;
            public readonly PropertyAccessor<string> StoreNameProperty;
            public readonly PropertyAccessor<string> ThumbprintProperty;
            public readonly PropertyAccessor<string> ThumbprintAlgorithmProperty;
            public readonly PropertyAccessor<Common.CertificateVisibility?> VisibilityProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.StoreLocationProperty = this.CreatePropertyAccessor<Common.CertStoreLocation?>("StoreLocation", BindingAccess.Read | BindingAccess.Write);
                this.StoreNameProperty = this.CreatePropertyAccessor<string>("StoreName", BindingAccess.Read | BindingAccess.Write);
                this.ThumbprintProperty = this.CreatePropertyAccessor<string>("Thumbprint", BindingAccess.Read | BindingAccess.Write);
                this.ThumbprintAlgorithmProperty = this.CreatePropertyAccessor<string>("ThumbprintAlgorithm", BindingAccess.Read | BindingAccess.Write);
                this.VisibilityProperty = this.CreatePropertyAccessor<Common.CertificateVisibility?>("Visibility", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.CertificateReference protocolObject) : base(BindingState.Bound)
            {
                this.StoreLocationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Common.CertStoreLocation>(protocolObject.StoreLocation),
                    "StoreLocation",
                    BindingAccess.Read | BindingAccess.Write);
                this.StoreNameProperty = this.CreatePropertyAccessor(
                    protocolObject.StoreName,
                    "StoreName",
                    BindingAccess.Read | BindingAccess.Write);
                this.ThumbprintProperty = this.CreatePropertyAccessor(
                    protocolObject.Thumbprint,
                    "Thumbprint",
                    BindingAccess.Read | BindingAccess.Write);
                this.ThumbprintAlgorithmProperty = this.CreatePropertyAccessor(
                    protocolObject.ThumbprintAlgorithm,
                    "ThumbprintAlgorithm",
                    BindingAccess.Read | BindingAccess.Write);
                this.VisibilityProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.ParseCertificateVisibility(protocolObject.Visibility),
                    "Visibility",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateReference"/> class.
        /// </summary>
        public CertificateReference()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal CertificateReference(Models.CertificateReference protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region CertificateReference

        /// <summary>
        /// Gets or sets the <see cref="Common.CertStoreLocation"/> for the certificate.
        /// </summary>
        public Common.CertStoreLocation? StoreLocation
        {
            get { return this.propertyContainer.StoreLocationProperty.Value; }
            set { this.propertyContainer.StoreLocationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name of the name of the certificate store. Besides <see cref="System.Security.Cryptography.X509Certificates.StoreName"/> 
        /// the value can have a custom store name.
        /// </summary>
        public string StoreName
        {
            get { return this.propertyContainer.StoreNameProperty.Value; }
            set { this.propertyContainer.StoreNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the certificate thumbprint property of the certificate.
        /// </summary>
        public string Thumbprint
        {
            get { return this.propertyContainer.ThumbprintProperty.Value; }
            set { this.propertyContainer.ThumbprintProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the certificate thumbprint algorithm. Currently sha1 is the only supported algorithm.
        /// </summary>
        public string ThumbprintAlgorithm
        {
            get { return this.propertyContainer.ThumbprintAlgorithmProperty.Value; }
            set { this.propertyContainer.ThumbprintAlgorithmProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the set of users that can get to the private data of the installed certificate. 
        /// </summary>
        public Common.CertificateVisibility? Visibility
        {
            get { return this.propertyContainer.VisibilityProperty.Value; }
            set { this.propertyContainer.VisibilityProperty.Value = value; }
        }

        #endregion // CertificateReference

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.CertificateReference ITransportObjectProvider<Models.CertificateReference>.GetTransportObject()
        {
            Models.CertificateReference result = new Models.CertificateReference()
            {
                StoreLocation = UtilitiesInternal.MapNullableEnum<Models.CertificateStoreLocation>(this.StoreLocation),
                StoreName = this.StoreName,
                Thumbprint = this.Thumbprint,
                ThumbprintAlgorithm = this.ThumbprintAlgorithm,
                Visibility = UtilitiesInternal.CertificateVisibilityToList(this.Visibility),
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<CertificateReference> ConvertFromProtocolCollection(IEnumerable<Models.CertificateReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<CertificateReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new CertificateReference(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<CertificateReference> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.CertificateReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<CertificateReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new CertificateReference(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<CertificateReference> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.CertificateReference> protoCollection)
        {
            IReadOnlyList<CertificateReference> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new CertificateReference(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}