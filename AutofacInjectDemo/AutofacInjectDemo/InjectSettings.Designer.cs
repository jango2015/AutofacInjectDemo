﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutofacInjectDemo {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class InjectSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static InjectSettings defaultInstance = ((InjectSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new InjectSettings())));
        
        public static InjectSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E1.dll,E2.dll")]
        public string EmoudleAssemblyFileNames {
            get {
                return ((string)(this["EmoudleAssemblyFileNames"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E2,E1")]
        public string EModuleProcess {
            get {
                return ((string)(this["EModuleProcess"]));
            }
            set {
                this["EModuleProcess"] = value;
            }
        }
    }
}
