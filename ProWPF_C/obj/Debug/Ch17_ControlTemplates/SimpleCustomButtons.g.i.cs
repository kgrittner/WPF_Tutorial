﻿#pragma checksum "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "21B764F10825B00CF7C4B039BDF8ABCF"
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


namespace ProWPF_C.Ch17_ControlTemplates {
    
    
    /// <summary>
    /// SimpleCustomButtons
    /// </summary>
    public partial class SimpleCustomButtons : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdOne;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdTwo;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdThree;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdFour;
        
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
            System.Uri resourceLocater = new System.Uri("/ProWPF_C;component/ch17_controltemplates/simplecustombuttons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
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
            this.cmdOne = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
            this.cmdOne.Click += new System.Windows.RoutedEventHandler(this.Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmdTwo = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
            this.cmdTwo.Click += new System.Windows.RoutedEventHandler(this.Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmdThree = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
            this.cmdThree.Click += new System.Windows.RoutedEventHandler(this.Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmdFour = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Ch17_ControlTemplates\SimpleCustomButtons.xaml"
            this.cmdFour.Click += new System.Windows.RoutedEventHandler(this.Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

