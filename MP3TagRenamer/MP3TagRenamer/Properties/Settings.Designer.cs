﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MP3TagRenamer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastUsedPath {
            get {
                return ((string)(this["LastUsedPath"]));
            }
            set {
                this["LastUsedPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection VisitedPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["VisitedPaths"]));
            }
            set {
                this["VisitedPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\w\\s]*")]
        public string regex_album {
            get {
                return ((string)(this["regex_album"]));
            }
            set {
                this["regex_album"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\w\\s]*")]
        public string regex_artist {
            get {
                return ((string)(this["regex_artist"]));
            }
            set {
                this["regex_artist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\w\\s,\\(\\)-]*")]
        public string regex_titel {
            get {
                return ((string)(this["regex_titel"]));
            }
            set {
                this["regex_titel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\d]{1,2}")]
        public string regex_tracknr {
            get {
                return ((string)(this["regex_tracknr"]));
            }
            set {
                this["regex_tracknr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\d]{4}")]
        public string regex_year {
            get {
                return ((string)(this["regex_year"]));
            }
            set {
                this["regex_year"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList RegExpHistoryList {
            get {
                return ((global::System.Collections.ArrayList)(this["RegExpHistoryList"]));
            }
            set {
                this["RegExpHistoryList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-GB")]
        public string LanguageUsed {
            get {
                return ((string)(this["LanguageUsed"]));
            }
            set {
                this["LanguageUsed"] = value;
            }
        }
    }
}
