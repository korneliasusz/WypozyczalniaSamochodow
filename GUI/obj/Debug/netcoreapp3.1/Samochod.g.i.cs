// Updated by XamlIntelliSenseFileGenerator 05.01.2021 15:14:52
#pragma checksum "..\..\..\Samochod.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B88E5C267F09EBA13C4F921130BCE1B7C9E75224"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI
{


    /// <summary>
    /// Samochod
    /// </summary>
    public partial class Samochod : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI;V1.0.0.0;component/samochod.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Samochod.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label label_szczegoly;
        internal System.Windows.Controls.Label label_marka;
        internal System.Windows.Controls.Label label_model;
        internal System.Windows.Controls.Label label_rejestracyjny;
        internal System.Windows.Controls.Label label_pojemnosc;
        internal System.Windows.Controls.Label label_vin;
        internal System.Windows.Controls.Label label_rodzajsilnika;
        internal System.Windows.Controls.Label label_automat;
        internal System.Windows.Controls.Label label_cena;
        internal System.Windows.Controls.TextBox txt_marka;
        internal System.Windows.Controls.TextBox txt_model;
        internal System.Windows.Controls.TextBox txt_rejestracyjny;
        internal System.Windows.Controls.TextBox txt_pojemnosc;
        internal System.Windows.Controls.TextBox txt_vin;
        internal System.Windows.Controls.TextBox txt_automat;
        internal System.Windows.Controls.TextBox txt_cena;
        internal System.Windows.Controls.ComboBox cmb_rodzajsilnika;
    }
}

