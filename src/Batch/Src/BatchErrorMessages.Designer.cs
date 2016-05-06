﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Batch {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class BatchErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BatchErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Batch.BatchErrorMessages", typeof(BatchErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Addition of task {0} failed with unexpected status code {1}.
        /// </summary>
        internal static string AddTaskCollectionTerminated {
            get {
                return ResourceManager.GetString("AddTaskCollectionTerminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task {0} reported AddTaskResultAction.UnretryableFailure.
        /// </summary>
        internal static string AddTaskResultActionUnretryableFailure {
            get {
                return ResourceManager.GetString("AddTaskResultActionUnretryableFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attempt was made to use an instance of BatchClient that is in the closed state.  No further calls to the Batch Service can be made with that instance.  This can happen if the instance was explicitly closed or if the BatchClient.Dispose() method was called..
        /// </summary>
        internal static string BatchClientIsClosed {
            get {
                return ResourceManager.GetString("BatchClientIsClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This BatchRequest has started executing and can no longer be modified..
        /// </summary>
        internal static string BatchRequestCannotBeModified {
            get {
                return ResourceManager.GetString("BatchRequestCannotBeModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} can only be run once..
        /// </summary>
        internal static string CanOnlyBeRunOnceFailure {
            get {
                return ResourceManager.GetString("CanOnlyBeRunOnceFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Items contained in collection must not be null.
        /// </summary>
        internal static string CollectionMustNotContainNull {
            get {
                return ResourceManager.GetString("CollectionMustNotContainNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least one behavior of type {0}.
        /// </summary>
        internal static string GeneralBehaviorMissing {
            get {
                return ResourceManager.GetString("GeneralBehaviorMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is in an invalid state.  Write access is not allowed..
        /// </summary>
        internal static string GeneralObjectInInvalidState {
            get {
                return ResourceManager.GetString("GeneralObjectInInvalidState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simultaneous Commit operators are forbidden..
        /// </summary>
        internal static string GeneralSimultaneousCommitsForbidden {
            get {
                return ResourceManager.GetString("GeneralSimultaneousCommitsForbidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect type returned..
        /// </summary>
        internal static string IncorrectTypeReturned {
            get {
                return ResourceManager.GetString("IncorrectTypeReturned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Monitor requires all instances to have the same server-side parent..
        /// </summary>
        internal static string MonitorInstancesMustHaveSameServerSideParent {
            get {
                return ResourceManager.GetString("MonitorInstancesMustHaveSameServerSideParent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more requests to the Azure Batch service failed..
        /// </summary>
        internal static string MultipleParallelRequestsHitUnexpectedErrors {
            get {
                return ResourceManager.GetString("MultipleParallelRequestsHitUnexpectedErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is forbidden on bound objects..
        /// </summary>
        internal static string OperationForbiddenOnBoundObjects {
            get {
                return ResourceManager.GetString("OperationForbiddenOnBoundObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is forbidden on unbound objects..
        /// </summary>
        internal static string OperationForbiddenOnUnboundObjects {
            get {
                return ResourceManager.GetString("OperationForbiddenOnUnboundObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} cannot be read while the object is in the {1} state..
        /// </summary>
        internal static string PropertiesReadAccessViolation {
            get {
                return ResourceManager.GetString("PropertiesReadAccessViolation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} cannot be modified while the object is in the {1} state..
        /// </summary>
        internal static string PropertiesWriteAccessViolation {
            get {
                return ResourceManager.GetString("PropertiesWriteAccessViolation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End task id must be greater than or equal to the start task id..
        /// </summary>
        internal static string TaskIdRangeCannotHaveEndLessThanStart {
            get {
                return ResourceManager.GetString("TaskIdRangeCannotHaveEndLessThanStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End task id must be greater or equal to 0..
        /// </summary>
        internal static string TaskIdRangeCannotHaveNegativeEnd {
            get {
                return ResourceManager.GetString("TaskIdRangeCannotHaveNegativeEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First task id must be greater or equal to 0..
        /// </summary>
        internal static string TaskIdRangeCannotHaveNegativeStart {
            get {
                return ResourceManager.GetString("TaskIdRangeCannotHaveNegativeStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} does not support an expand clause..
        /// </summary>
        internal static string TypeDoesNotSupportExpandClause {
            get {
                return ResourceManager.GetString("TypeDoesNotSupportExpandClause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} does not support a filter clause..
        /// </summary>
        internal static string TypeDoesNotSupportFilterClause {
            get {
                return ResourceManager.GetString("TypeDoesNotSupportFilterClause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} does not support a select clause..
        /// </summary>
        internal static string TypeDoesNotSupportSelectClause {
            get {
                return ResourceManager.GetString("TypeDoesNotSupportSelectClause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown AddTaskResultAction value: {0}.
        /// </summary>
        internal static string UnknownAddTaskResultAction {
            get {
                return ResourceManager.GetString("UnknownAddTaskResultAction", resourceCulture);
            }
        }
    }
}
