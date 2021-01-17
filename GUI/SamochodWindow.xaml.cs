using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Projekt_Susz_Kulec_Koterwa;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy SamochodWindow.xaml
    /// </summary>
    public partial class SamochodWindow : Window
    {
        Samochod samochod;
        
        public SamochodWindow()
        {
            InitializeComponent();
        }

        public SamochodWindow(Samochod samochod) : this()
        {
            this.samochod = samochod;
            txt_marka.Text = this.samochod.Marka1;
            txt_model.Text = this.samochod.Model1;
            txt_rejestracyjny.Text = this.samochod.Nr_rejestracyjny;
            txt_pojemnosc.Text = this.samochod.Pojemnosc_Silnika.ToString();
            txt_vin.Text = this.samochod.NR_VIN;
            txt_automat.Text = (this.samochod.Automat == true) ? "tak" : "nie";
            txt_cena.Text = this.samochod.Cena.ToString();
            cmb_rodzajsilnika.Text = ((this.samochod.Silnik == Samochod.Rodzaj_Silnika.benzyna) ? "benzyna" : ((this.samochod.Silnik == Samochod.Rodzaj_Silnika.diesel) ? "diesel" : ((this.samochod.Silnik == Samochod.Rodzaj_Silnika.gaz) ? "gaz" : (this.samochod.Silnik == Samochod.Rodzaj_Silnika.hybryda_plug_in) ? "hybryda plug in" : "hybryda")));
        }

       

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (txt_marka.Text != "" && txt_model.Text != "" && txt_rejestracyjny.Text != "" && txt_vin.Text != "" && txt_cena.Text != "" && txt_automat.Text != "")
            {
                samochod.Marka1 = txt_marka.Text;
                samochod.Model1 = txt_model.Text;
                samochod.Nr_rejestracyjny = txt_rejestracyjny.Text;
                samochod.NR_VIN = txt_vin.Text;
                samochod.Cena = Convert.ToDouble(txt_cena.Text);
                samochod.Automat = (txt_automat.Text == "tak") ? true : false;
                samochod.Pojemnosc_Silnika = Convert.ToDouble(txt_pojemnosc.Text);
                samochod.Silnik = ((cmb_rodzajsilnika.Text == "benzyna") ? Samochod.Rodzaj_Silnika.benzyna : ((cmb_rodzajsilnika.Text == "diesel") ? Samochod.Rodzaj_Silnika.diesel : ((cmb_rodzajsilnika.Text == "gaz") ? Samochod.Rodzaj_Silnika.gaz : ((cmb_rodzajsilnika.Text == "hybryda_plug_in") ? Samochod.Rodzaj_Silnika.hybryda_plug_in : Samochod.Rodzaj_Silnika.hybryda))));
                samochod.Wewnetrzny_nr_ID = samochod.Marka1[0].ToString() + samochod.Model1[0].ToString() + samochod.NR_VIN[0] + samochod.NR_VIN[1] + samochod.NR_VIN[2] + Samochod.Licznik.ToString("D3");
                DialogResult = true;
            }
        }


    }
}
