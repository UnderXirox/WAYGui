﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WayGUI.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WayGUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Disable Address Correction.
        /// </summary>
        internal static string AddressCorrectionDisable {
            get {
                return ResourceManager.GetString("AddressCorrectionDisable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Address Correction.
        /// </summary>
        internal static string AddressCorrectionEnable {
            get {
                return ResourceManager.GetString("AddressCorrectionEnable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable Erase.
        /// </summary>
        internal static string EraseDisable {
            get {
                return ResourceManager.GetString("EraseDisable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Erase.
        /// </summary>
        internal static string EraseEnable {
            get {
                return ResourceManager.GetString("EraseEnable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto Select NAND for write is currently not supported...
        ///.
        /// </summary>
        internal static string ErrorAutoWriteNANDNotSupported {
            get {
                return ResourceManager.GetString("ErrorAutoWriteNANDNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: While getting NAND{1} info: {0}.
        /// </summary>
        internal static string ErrorGettingNandInfo {
            get {
                return ResourceManager.GetString("ErrorGettingNandInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: Something went horribly wrong!!.
        /// </summary>
        internal static string ErrorHorrible {
            get {
                return ResourceManager.GetString("ErrorHorrible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initilization failed, Python return code: {0}.
        /// </summary>
        internal static string ErrorInitFailed {
            get {
                return ResourceManager.GetString("ErrorInitFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could only initalize NAND1!
        ///NAND0 failed with: {0}.
        /// </summary>
        internal static string ErrorInitNAND0FailedNAND1OK {
            get {
                return ResourceManager.GetString("ErrorInitNAND0FailedNAND1OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could only initalize NAND0!
        ///NAND1 failed with: {0}.
        /// </summary>
        internal static string ErrorInitNAND1FailedNAND0OK {
            get {
                return ResourceManager.GetString("ErrorInitNAND1FailedNAND0OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not initalize NAND0: {0}
        ///Could not initalize NAND1: {1}.
        /// </summary>
        internal static string ErrorInitNANDFailed {
            get {
                return ResourceManager.GetString("ErrorInitNANDFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR.
        /// </summary>
        internal static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: Something went wrong while saving the script path, you&apos;ll probably need to select the path again next time you run the app....
        /// </summary>
        internal static string ErrorWhileSavingScriptPath {
            get {
                return ResourceManager.GetString("ErrorWhileSavingScriptPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Binary files|*.bin|All Files|*.*.
        /// </summary>
        internal static string FilterBin {
            get {
                return ResourceManager.GetString("FilterBin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diff Files|*.diff|All Files|*.*.
        /// </summary>
        internal static string FilterDiff {
            get {
                return ResourceManager.GetString("FilterDiff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Executables|*.exe|All Files|*.*.
        /// </summary>
        internal static string FilterExe {
            get {
                return ResourceManager.GetString("FilterExe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log files|*.log|All Files|*.*.
        /// </summary>
        internal static string FilterLog {
            get {
                return ResourceManager.GetString("FilterLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Python scripts|*.py|All Files|*.*.
        /// </summary>
        internal static string FilterPy {
            get {
                return ResourceManager.GetString("FilterPy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.consoleopen.com/.
        /// </summary>
        internal static string LinkConsoleOpen {
            get {
                return ResourceManager.GetString("LinkConsoleOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://donate.xeupd.com/.
        /// </summary>
        internal static string LinkDonate {
            get {
                return ResourceManager.GetString("LinkDonate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.homebrew-connection.org/.
        /// </summary>
        internal static string LinkHomebrewConnection {
            get {
                return ResourceManager.GetString("LinkHomebrewConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No NANDay.py = no go!.
        /// </summary>
        internal static string NotFoundNANDWay {
            get {
                return ResourceManager.GetString("NotFoundNANDWay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No NORway.py = no go!.
        /// </summary>
        internal static string NotFoundNORway {
            get {
                return ResourceManager.GetString("NotFoundNORway", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Python = no go!.
        /// </summary>
        internal static string NotFoundPython {
            get {
                return ResourceManager.GetString("NotFoundPython", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you are working on a PS3 (most likely you are) You should now turn it on before doing anything else.
        /// </summary>
        internal static string PS3InitMessage {
            get {
                return ResourceManager.GetString("PS3InitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Diff file to use.
        /// </summary>
        internal static string SelectDiffFileToUse {
            get {
                return ResourceManager.GetString("SelectDiffFileToUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select file to write.
        /// </summary>
        internal static string SelectFileToWrite {
            get {
                return ResourceManager.GetString("SelectFileToWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a memory device to work with!.
        /// </summary>
        internal static string SelectMemory {
            get {
                return ResourceManager.GetString("SelectMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Select NORway.py &amp; NANDWay.py Path in the tools menu!.
        /// </summary>
        internal static string SelectNORwayAndNANDWayInTools {
            get {
                return ResourceManager.GetString("SelectNORwayAndNANDWayInTools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select NORway.py or NANDWay.py.
        /// </summary>
        internal static string SelectNORwayOrNANDWay {
            get {
                return ResourceManager.GetString("SelectNORwayOrNANDWay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a port to use!.
        /// </summary>
        internal static string SelectPort {
            get {
                return ResourceManager.GetString("SelectPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select where you have installed Python.
        /// </summary>
        internal static string SelectPythonPath {
            get {
                return ResourceManager.GetString("SelectPythonPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select Python path in the tools menu!.
        /// </summary>
        internal static string SelectPythonPathInTools {
            get {
                return ResourceManager.GetString("SelectPythonPathInTools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select where to save yor dump.
        /// </summary>
        internal static string SelectSaveDump {
            get {
                return ResourceManager.GetString("SelectSaveDump", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select where to save your dumps.
        /// </summary>
        internal static string SelectSaveDumps {
            get {
                return ResourceManager.GetString("SelectSaveDumps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select where to save the output log....
        /// </summary>
        internal static string SelectSaveLog {
            get {
                return ResourceManager.GetString("SelectSaveLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select file to verify NOR against.
        /// </summary>
        internal static string SelectVerifyFile {
            get {
                return ResourceManager.GetString("SelectVerifyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to search for NORway/NANDWay port because:
        ///{0}.
        /// </summary>
        internal static string UnableToSearchForNORWayNANDWayPort {
            get {
                return ResourceManager.GetString("UnableToSearchForNORWayNANDWayPort", resourceCulture);
            }
        }
    }
}
