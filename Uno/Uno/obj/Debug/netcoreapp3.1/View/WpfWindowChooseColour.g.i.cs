﻿#pragma checksum "..\..\..\..\View\WpfWindowChooseColour.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F81DA1DA3DBDD2D15576E8D15A6079537216041"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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
using Uno.View;


namespace Uno.View {
    
    
    /// <summary>
    /// WpfWindowChooseColour
    /// </summary>
    public partial class WpfWindowChooseColour : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\View\WpfWindowChooseColour.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPickName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\WpfWindowChooseColour.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRed;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\WpfWindowChooseColour.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGren;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\WpfWindowChooseColour.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBlue;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\WpfWindowChooseColour.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonYellow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Uno;component/view/wpfwindowchoosecolour.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WpfWindowChooseColour.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelPickName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.buttonRed = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\View\WpfWindowChooseColour.xaml"
            this.buttonRed.Click += new System.Windows.RoutedEventHandler(this.buttonRed_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonGren = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\WpfWindowChooseColour.xaml"
            this.buttonGren.Click += new System.Windows.RoutedEventHandler(this.buttonGren_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonBlue = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\View\WpfWindowChooseColour.xaml"
            this.buttonBlue.Click += new System.Windows.RoutedEventHandler(this.buttonBlue_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonYellow = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\View\WpfWindowChooseColour.xaml"
            this.buttonYellow.Click += new System.Windows.RoutedEventHandler(this.buttonYellow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

