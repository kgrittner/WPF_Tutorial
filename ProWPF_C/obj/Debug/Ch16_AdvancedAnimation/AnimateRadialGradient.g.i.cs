﻿#pragma checksum "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E16B08589ACF5E91EC9D9CA62C92E6E2"
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


namespace ProWPF_C.Ch16_AdvancedAnimation {
    
    
    /// <summary>
    /// AnimateRadialGradient
    /// </summary>
    public partial class AnimateRadialGradient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProWPF_C.Ch16_AdvancedAnimation.AnimateRadialGradient myWind;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard myStoryBoard;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.PointAnimationUsingKeyFrames myPoint;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPointA;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPointB;
        
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
            System.Uri resourceLocater = new System.Uri("/ProWPF_C;component/ch16_advancedanimation/animateradialgradient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ch16_AdvancedAnimation\AnimateRadialGradient.xaml"
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
            this.myWind = ((ProWPF_C.Ch16_AdvancedAnimation.AnimateRadialGradient)(target));
            return;
            case 2:
            this.myStoryBoard = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 3:
            this.myPoint = ((System.Windows.Media.Animation.PointAnimationUsingKeyFrames)(target));
            return;
            case 4:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.ellipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.txtPointA = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtPointB = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

