﻿#pragma checksum "..\..\..\Ch15_Animation\CodeAnimation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DE8434B22977210AF82F4B82240085F8"
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


namespace ProWPF_C.Ch15_Animation {
    
    
    /// <summary>
    /// CodeAnimation
    /// </summary>
    public partial class CodeAnimation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdGrow;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdShrink;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdGrowIncrementally;
        
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
            System.Uri resourceLocater = new System.Uri("/ProWPF_C;component/ch15_animation/codeanimation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
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
            this.cmdGrow = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
            this.cmdGrow.Click += new System.Windows.RoutedEventHandler(this.cmdGrow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmdShrink = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
            this.cmdShrink.Click += new System.Windows.RoutedEventHandler(this.cmdShrink_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmdGrowIncrementally = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Ch15_Animation\CodeAnimation.xaml"
            this.cmdGrowIncrementally.Click += new System.Windows.RoutedEventHandler(this.cmdGrowIncrementally_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

