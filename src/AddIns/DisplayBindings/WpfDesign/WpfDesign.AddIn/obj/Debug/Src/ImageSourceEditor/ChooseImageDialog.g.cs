﻿#pragma checksum "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B1A6C62BF6A934C3688DE4A22878ADB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ICSharpCode.WpfDesign.AddIn.ImageSourceEditor {
    
    
    /// <summary>
    /// ChooseImageDialog
    /// </summary>
    public partial class ChooseImageDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox imgDisplay;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txURL;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxOk;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ICSharpCode.WpfDesign.AddIn;component/src/imagesourceeditor/chooseimagedialog.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgDisplay = ((System.Windows.Controls.ListBox)(target));
            
            #line 43 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
            this.imgDisplay.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ImageDisplayDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 86 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txURL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uxOk = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
            this.uxOk.Click += new System.Windows.RoutedEventHandler(this.OkClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uxCancel = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\Src\ImageSourceEditor\ChooseImageDialog.xaml"
            this.uxCancel.Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

