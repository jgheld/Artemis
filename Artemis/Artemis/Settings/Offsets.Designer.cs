﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Artemis.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Offsets : global::System.Configuration.ApplicationSettingsBase {
        
        private static Offsets defaultInstance = ((Offsets)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Offsets())));
        
        public static Offsets Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"Game\":\"RocketLeague\",\"GameVersion\":\"1.10\",\"GameAddresses\":[{\"Description\":\"Boos" +
            "t\",\"BasePointer\":{\"value\":21998084},\"Offsets\":[88,1452,1780,540]}]}")]
        public string RocketLeague {
            get {
                return ((string)(this["RocketLeague"]));
            }
            set {
                this["RocketLeague"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"Game\":\"Witcher3\",\"GameVersion\":\"1.11\",\"GameAddresses\":[{\"Description\":\"Sign\",\"B" +
            "asePointer\":{\"value\":42942304},\"Offsets\":[40,16,32,3008]}]}")]
        public string Witcher3 {
            get {
                return ((string)(this["Witcher3"]));
            }
            set {
                this["Witcher3"] = value;
            }
        }
    }
}
