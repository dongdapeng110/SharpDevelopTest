//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSharpCode.XamlDesigner.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0,0,0,0")]
        public global::System.Windows.Rect MainWindowRect {
            get {
                return ((global::System.Windows.Rect)(this["MainWindowRect"]));
            }
            set {
                this["MainWindowRect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<DockingManager>
    <ResizingPanel Orientation=""Horizontal"">
        <ResizingPanel ResizeWidth=""200"" Orientation=""Vertical"">
            <DockablePane ResizeHeight=""441.36166666666668"" Anchor=""Left"">
                <DockableContent Name=""content1"" AutoHide=""false"" />
            </DockablePane>
            <DockablePane ResizeWidth=""200"" Anchor=""Left"">
                <DockableContent Name=""content2"" AutoHide=""false"" />
            </DockablePane>
        </ResizingPanel>
        <ResizingPanel Orientation=""Vertical"">
            <DocumentPanePlaceHolder />
            <DockablePane ResizeHeight=""138"" Anchor=""Bottom"">
                <DockableContent Name=""content3"" AutoHide=""false"" />
            </DockablePane>
        </ResizingPanel>
        <DockablePane ResizeWidth=""271"" Anchor=""Right"">
            <DockableContent Name=""content4"" AutoHide=""false"" />
        </DockablePane>
    </ResizingPanel>
    <Hidden />
    <Windows />
</DockingManager>")]
        public string AvalonDockLayout {
            get {
                return ((string)(this["AvalonDockLayout"]));
            }
            set {
                this["AvalonDockLayout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentFiles"]));
            }
            set {
                this["RecentFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>%ProgramFiles%\Reference Assemblies\Microsoft\Framework\v3.0\PresentationFramework.dll</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AssemblyList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AssemblyList"]));
            }
            set {
                this["AssemblyList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Maximized")]
        public global::System.Windows.WindowState MainWindowState {
            get {
                return ((global::System.Windows.WindowState)(this["MainWindowState"]));
            }
            set {
                this["MainWindowState"] = value;
            }
        }
    }
}
