﻿#pragma checksum "..\..\..\UserControl\AddContactsUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "063611C83EBED4307470759858C693E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace CallerIdIntegration.UserControl {
    
    
    /// <summary>
    /// AddContactsUserControl
    /// </summary>
    public partial class AddContactsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderCustomerName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCustomerName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonReset;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\UserControl\AddContactsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/CallerIdIntegration;component/usercontrol/addcontactsusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControl\AddContactsUserControl.xaml"
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
            this.BorderCustomerName = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.TextBoxCustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BorderPhoneNumber = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.TextBoxPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\UserControl\AddContactsUserControl.xaml"
            this.ButtonSave.Click += new System.Windows.RoutedEventHandler(this.ButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonReset = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\UserControl\AddContactsUserControl.xaml"
            this.ButtonReset.Click += new System.Windows.RoutedEventHandler(this.ButtonReset_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBlockMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

