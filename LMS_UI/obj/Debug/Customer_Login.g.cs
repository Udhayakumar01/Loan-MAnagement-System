﻿#pragma checksum "..\..\Customer_Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24A81B72264120784C04CE72C38D97DF634C9CE28F6321E9AD061C6383A7AACE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LMS_UI;
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


namespace LMS_UI {
    
    
    /// <summary>
    /// Customer_Login
    /// </summary>
    public partial class Customer_Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 141 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Back;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Password;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_Password;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Login;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Register;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNewUser;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\Customer_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_LoginPage;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS_UI;component/customer_login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customer_Login.xaml"
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
            this.btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\Customer_Login.xaml"
            this.btn_Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl_CustomerId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbl_Password = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_CustomerId = ((System.Windows.Controls.TextBox)(target));
            
            #line 144 "..\..\Customer_Login.xaml"
            this.txt_CustomerId.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_CustomerId_PreviewText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.btn_Login = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\Customer_Login.xaml"
            this.btn_Login.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Login);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Register = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\Customer_Login.xaml"
            this.btn_Register.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Register);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblNewUser = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lbl_LoginPage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
