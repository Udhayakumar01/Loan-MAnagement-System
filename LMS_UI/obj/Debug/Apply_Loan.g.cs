﻿#pragma checksum "..\..\Apply_Loan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "60546805F6E5DC1050A03B4F421FC503538C8EFCF2B1E0137A5FF0783F0FB0A3"
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
    /// Apply_Loan
    /// </summary>
    public partial class Apply_Loan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 111 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_LoanAmount;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_LoanType;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Tenure;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_LoanAmount;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Tenure;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txt_LoanType;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_CustomerId;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lbl_Apply;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\Apply_Loan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lbl_Back;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS_UI;component/apply_loan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Apply_Loan.xaml"
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
            this.lbl_LoanAmount = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lbl_LoanType = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbl_Tenure = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_LoanAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\Apply_Loan.xaml"
            this.txt_LoanAmount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_LoanAmount_PreviewText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_Tenure = ((System.Windows.Controls.TextBox)(target));
            
            #line 115 "..\..\Apply_Loan.xaml"
            this.txt_Tenure.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_Tenure_PreviewText);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_LoanType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.lbl_CustomerId = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txt_CustomerId = ((System.Windows.Controls.TextBox)(target));
            
            #line 118 "..\..\Apply_Loan.xaml"
            this.txt_CustomerId.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_CustomerId_PreviewText);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_Apply = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\Apply_Loan.xaml"
            this.lbl_Apply.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Apply);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lbl_Back = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\Apply_Loan.xaml"
            this.lbl_Back.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
