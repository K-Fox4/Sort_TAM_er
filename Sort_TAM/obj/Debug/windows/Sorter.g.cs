﻿#pragma checksum "..\..\..\windows\Sorter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEFC0E5A4D73A86E6EA9C0A4C4123B85DE52E12DAB45A4DE56E5CE03A0AB647D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sort_TAM.windows;
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


namespace Sort_TAM.windows {
    
    
    /// <summary>
    /// Sorter
    /// </summary>
    public partial class Sorter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Sort_TAM.windows.Sorter Sorter_Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Input_String_Label;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_String_Textbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sort_Button;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Output_String_Label;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Output_String_Textbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh_Button;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\windows\Sorter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Refresh_Image;
        
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
            System.Uri resourceLocater = new System.Uri("/Sort_TAM;component/windows/sorter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\Sorter.xaml"
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
            this.Sorter_Window = ((Sort_TAM.windows.Sorter)(target));
            return;
            case 2:
            this.Input_String_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Input_String_Textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\windows\Sorter.xaml"
            this.Input_String_Textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Input_String_Textbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Sort_Button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\windows\Sorter.xaml"
            this.Sort_Button.Click += new System.Windows.RoutedEventHandler(this.Sort_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Output_String_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Output_String_Textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\windows\Sorter.xaml"
            this.Output_String_Textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Output_String_Textbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Refresh_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\windows\Sorter.xaml"
            this.Refresh_Button.Click += new System.Windows.RoutedEventHandler(this.Refresh_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Refresh_Image = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
