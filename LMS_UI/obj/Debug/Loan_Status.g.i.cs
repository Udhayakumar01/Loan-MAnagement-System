﻿#pragma checksum "..\..\Loan_Status.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57A80441936B73D31A9D7FB54B9BCC9C54D0FC0F8A4DE640D9A7565BF651C075"
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
    /// Loan_Status
    /// </summary>
    public partial class Loan_Status : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 107 "..\..\Loan_Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Loan_Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Loan_Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Loan_Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_View;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\Loan_Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Back;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS_UI;component/loan_status.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Loan_Status.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.lbl_CustomerId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txt_CustomerId = ((System.Windows.Controls.TextBox)(target));
            
            #line 109 "..\..\Loan_Status.xaml"
            this.txt_CustomerId.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_CustomerId_PreviewText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_View = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\Loan_Status.xaml"
            this.btn_View.Click += new System.Windows.RoutedEventHandler(this.Button_Click_View);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\Loan_Status.xaml"
            this.btn_Back.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

