﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Artemis.Modules.Games.TheDivision {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class TheDivision : global::System.Configuration.ApplicationSettingsBase {
        
        private static TheDivision defaultInstance = ((TheDivision)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TheDivision())));
        
        public static TheDivision Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Enabled {
            get {
                return ((bool)(this["Enabled"]));
            }
            set {
                this["Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string LastProfile {
            get {
                return ((string)(this["LastProfile"]));
            }
            set {
                this["LastProfile"] = value;
            }
        }
    }
}
