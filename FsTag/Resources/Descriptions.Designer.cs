﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FsTag.Resources {
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
    internal class Descriptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Descriptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FsTag.Resources.Descriptions", typeof(Descriptions).Assembly);
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
        ///   Looks up a localized string similar to Whether to send deleted items to the recycle bin..
        /// </summary>
        internal static string DeleteRecycle {
            get {
                return ResourceManager.GetString("DeleteRecycle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List the currently loaded documentation modules..
        /// </summary>
        internal static string DocModulesCommand {
            get {
                return ResourceManager.GetString("DocModulesCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extended information on various commands and topics in FsTag..
        /// </summary>
        internal static string DocsCommand {
            get {
                return ResourceManager.GetString("DocsCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the specified label on indexed files..
        /// </summary>
        internal static string LabelCommand {
            get {
                return ResourceManager.GetString("LabelCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only set labels where they aren&apos;t already set..
        /// </summary>
        internal static string LabelNewOp {
            get {
                return ResourceManager.GetString("LabelNewOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Print files that are currently tagged (in the index)..
        /// </summary>
        internal static string PrintCommand {
            get {
                return ResourceManager.GetString("PrintCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Print a list of valid print keys..
        /// </summary>
        internal static string PrintKeysCommand {
            get {
                return ResourceManager.GetString("PrintKeysCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recurse depth to tag up until. 0 (default) denotes no recursion, values less than 0 denote no limit..
        /// </summary>
        internal static string RecursiveOp {
            get {
                return ResourceManager.GetString("RecursiveOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Untag all indexed files..
        /// </summary>
        internal static string RemoveAllCommand {
            get {
                return ResourceManager.GetString("RemoveAllCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all labels from indexed files..
        /// </summary>
        internal static string RmLabelAllCommand {
            get {
                return ResourceManager.GetString("RmLabelAllCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the specified label from index files..
        /// </summary>
        internal static string RmLabelCommand {
            get {
                return ResourceManager.GetString("RmLabelCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adds files to the current session index based on the provided filter..
        /// </summary>
        internal static string TagCommand {
            get {
                return ResourceManager.GetString("TagCommand", resourceCulture);
            }
        }
    }
}
