﻿#pragma checksum "..\..\EasyquoteBossboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54FE2FE8C6D85130F0EA4CDEA617870DC4BF014D98EFFE2594A480D9D64751FD"
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
using easyquoteDesktop;


namespace easyquoteDesktop {
    
    
    /// <summary>
    /// EasyquoteBossboard
    /// </summary>
    public partial class EasyquoteBossboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid usersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_name;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_email;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_userId;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_id;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordbox_password;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordbox_passwordRepeat;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update_button;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_button;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_button;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\EasyquoteBossboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeForm_button;
        
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
            System.Uri resourceLocater = new System.Uri("/easyquoteDesktop;component/easyquotebossboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EasyquoteBossboard.xaml"
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
            this.usersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\EasyquoteBossboard.xaml"
            this.usersDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textbox_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textbox_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label_userId = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.combobox_id = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.passwordbox_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.passwordbox_passwordRepeat = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.update_button = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\EasyquoteBossboard.xaml"
            this.update_button.Click += new System.Windows.RoutedEventHandler(this.UpdateButton);
            
            #line default
            #line hidden
            return;
            case 9:
            this.clear_button = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\EasyquoteBossboard.xaml"
            this.clear_button.Click += new System.Windows.RoutedEventHandler(this.ClearButton);
            
            #line default
            #line hidden
            return;
            case 10:
            this.delete_button = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\EasyquoteBossboard.xaml"
            this.delete_button.Click += new System.Windows.RoutedEventHandler(this.DeleteButton);
            
            #line default
            #line hidden
            return;
            case 11:
            this.changeForm_button = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\EasyquoteBossboard.xaml"
            this.changeForm_button.Click += new System.Windows.RoutedEventHandler(this.ChangeFormToNewUserButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

