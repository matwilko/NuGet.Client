﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Build.Tasks.Pack {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Build.Tasks.Pack.Strings", typeof(Strings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to The assets file found does not contain a valid package spec. Try restoring the project again. The location of the assets file is {0}..
        /// </summary>
        internal static string AssetsFileDoesNotHaveValidPackageSpec {
            get {
                return ResourceManager.GetString("AssetsFileDoesNotHaveValidPackageSpec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assets file produced by restore does not exist. Try restoring the project again. The expected location of the assets file is {0}..
        /// </summary>
        internal static string AssetsFileNotFound {
            get {
                return ResourceManager.GetString("AssetsFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; to be packed was not found on disk..
        /// </summary>
        internal static string Error_FileNotFound {
            get {
                return ResourceManager.GetString("Error_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid metadata. Cannot specify both a License Expression and a License File..
        /// </summary>
        internal static string InvalidLicenseCombination {
            get {
                return ResourceManager.GetString("InvalidLicenseCombination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version string &apos;{0}&apos; is not supported by this toolset. The highest supported version is &apos;{1}&apos;. Either use a lower version or upgrade your toolset..
        /// </summary>
        internal static string InvalidLicenseExppressionVersion_VersionTooHigh {
            get {
                return ResourceManager.GetString("InvalidLicenseExppressionVersion_VersionTooHigh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The license expression &apos;{0}&apos; cannot be parsed succesfully. {1}.
        /// </summary>
        internal static string InvalidLicenseExpression {
            get {
                return ResourceManager.GetString("InvalidLicenseExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version string &apos;{0}&apos; for the License Expression is invalid..
        /// </summary>
        internal static string InvalidLicenseExpressionVersion {
            get {
                return ResourceManager.GetString("InvalidLicenseExpressionVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MinClientVersion string specified &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string InvalidMinClientVersion {
            get {
                return ResourceManager.GetString("InvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuspecProperties should be in the form of &quot;key1=value1;key2=value2&quot;..
        /// </summary>
        internal static string InvalidNuspecProperties {
            get {
                return ResourceManager.GetString("InvalidNuspecProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PackageReference {0} needs to have a valid version..
        /// </summary>
        internal static string InvalidPackageReferenceVersion {
            get {
                return ResourceManager.GetString("InvalidPackageReferenceVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PackageVersion string specified &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string InvalidPackageVersion {
            get {
                return ResourceManager.GetString("InvalidPackageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid target framework for the file &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidTargetFramework {
            get {
                return ResourceManager.GetString("InvalidTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot generate a package from a project which has IsPackable property set to false..
        /// </summary>
        internal static string IsPackableFalseError {
            get {
                return ResourceManager.GetString("IsPackableFalseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project was provided to the PackTask..
        /// </summary>
        internal static string NoPackItemProvided {
            get {
                return ResourceManager.GetString("NoPackItemProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PackageLicenseUrl cannot be used cannot be used in conjunction with the PackageLicenseFile and PackageLicenseExpression..
        /// </summary>
        internal static string NuGetLicenses_LicenseUrlCannotBeUsedInConjuctionWithLicense {
            get {
                return ResourceManager.GetString("NuGetLicenses_LicenseUrlCannotBeUsedInConjuctionWithLicense", resourceCulture);
            }
        }
    }
}
