﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartORDeliveryLib.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("SERVER=localhost;UID=hsn_builder;PWD=12345;database=SmartORDeliveryDB")]
        public string ConnectionStringSetting1 {
            get {
                return ((string)(this["ConnectionStringSetting1"]));
            }
            set {
                this["ConnectionStringSetting1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=localhost;Database=SmartORDeliveryDB;Trusted_Connection=True;")]
        public string ConnectionStringSetting {
            get {
                return ((string)(this["ConnectionStringSetting"]));
            }
            set {
                this["ConnectionStringSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\SMARTFOLDER\\")]
        public string MainFolderSetting {
            get {
                return ((string)(this["MainFolderSetting"]));
            }
            set {
                this["MainFolderSetting"] = value;
            }
        }
    }
}
