#pragma checksum "..\..\..\Interface\Busket.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6687D4B3132F04F9A5D4E658560B8CF539A776DA09303C55E96034144F55339"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Toy_Magazine;


namespace Toy_Magazine {
    
    
    /// <summary>
    /// Busket
    /// </summary>
    public partial class Busket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Interface\Busket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoProfile;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Interface\Busket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reference;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Interface\Busket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clean;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Interface\Busket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox allcost;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Interface\Busket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tousbusket;
        
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
            System.Uri resourceLocater = new System.Uri("/Toy Magazine;component/interface/busket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interface\Busket.xaml"
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
            
            #line 12 "..\..\..\Interface\Busket.xaml"
            ((Toy_Magazine.Busket)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Interface\Busket.xaml"
            ((Toy_Magazine.Busket)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoProfile = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Interface\Busket.xaml"
            this.GoProfile.Click += new System.Windows.RoutedEventHandler(this.GoProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Reference = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Interface\Busket.xaml"
            this.Reference.Click += new System.Windows.RoutedEventHandler(this.Reference_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Clean = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Interface\Busket.xaml"
            this.Clean.Click += new System.Windows.RoutedEventHandler(this.Clean_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.allcost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tousbusket = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Interface\Busket.xaml"
            this.tousbusket.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tousbusket_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

