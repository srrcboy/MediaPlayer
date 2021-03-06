﻿#pragma checksum "..\..\Library.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "137485DB3E399843F5DEF8B80ABED5EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace MediaPlayer {
    
    
    /// <summary>
    /// Library
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Library : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView TheTreeView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MediaPlayer;component/library.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Library.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TheTreeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 7 "..\..\Library.xaml"
            this.TheTreeView.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeView_MouseDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Library.xaml"
            this.TheTreeView.MouseMove += new System.Windows.Input.MouseEventHandler(this.TreeView_MouseMove);
            
            #line default
            #line hidden
            
            #line 9 "..\..\Library.xaml"
            this.TheTreeView.DragEnter += new System.Windows.DragEventHandler(this.TheTreeView_CheckDropTarget);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Library.xaml"
            this.TheTreeView.DragLeave += new System.Windows.DragEventHandler(this.TheTreeView_CheckDropTarget);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Library.xaml"
            this.TheTreeView.DragOver += new System.Windows.DragEventHandler(this.TheTreeView_CheckDropTarget);
            
            #line default
            #line hidden
            
            #line 12 "..\..\Library.xaml"
            this.TheTreeView.Drop += new System.Windows.DragEventHandler(this.TheTreeView_Drop);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

