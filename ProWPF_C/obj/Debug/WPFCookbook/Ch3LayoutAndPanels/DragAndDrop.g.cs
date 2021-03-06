﻿#pragma checksum "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "37DD0C4ACE5CDCAD8AAC1EF41D3D034A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace ProWPF_C.WPFCookbook.Ch3LayoutAndPanels {
    
    
    /// <summary>
    /// DragAndDrop
    /// </summary>
    public partial class DragAndDrop : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas _source;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel _target;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _allowEllipsesOnly;
        
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
            System.Uri resourceLocater = new System.Uri("/ProWPF_C;component/wpfcookbook/ch3layoutandpanels/draganddrop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
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
            this._source = ((System.Windows.Controls.Canvas)(target));
            
            #line 17 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
            this._source.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnBeginDrag);
            
            #line default
            #line hidden
            return;
            case 2:
            this._target = ((System.Windows.Controls.WrapPanel)(target));
            
            #line 22 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
            this._target.Drop += new System.Windows.DragEventHandler(this.OnDrop);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
            this._target.DragEnter += new System.Windows.DragEventHandler(this.OnDragEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
            this._target.DragOver += new System.Windows.DragEventHandler(this.OnDragEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\WPFCookbook\Ch3LayoutAndPanels\DragAndDrop.xaml"
            this._target.DragLeave += new System.Windows.DragEventHandler(this.OnDragEnter);
            
            #line default
            #line hidden
            return;
            case 3:
            this._allowEllipsesOnly = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

