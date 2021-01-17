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
    /// Logika interakcji dla klasy WypozyczenieWindow.xaml
    /// </summary>
    public partial class WypozyczenieWindow : Window
    {
        Wypozyczenie wypozyczenie;
        
        public WypozyczenieWindow()
        {
            InitializeComponent();
            
        }

        public WypozyczenieWindow(Wypozyczenie wypozyczenie) : this()
        {

            this.wypozyczenie = wypozyczenie;
            txt_dataodd.Text = this.wypozyczenie.Data_Oddania.ToString();
            txt_datawyp.Text = this.wypozyczenie.Data_Wypozyczenia.ToString();
            txt_koszt.Text = this.wypozyczenie.KosztWypozyczenia().ToString("C");
            txt_nazwisko.Text = this.wypozyczenie.Nazwisko;
            txt_numer.Text = this.wypozyczenie.Numer_kontaktowy;
            txt_pesel.Text = this.wypozyczenie.PESEL;
            txt_auto.Text = this.wypozyczenie.Marka1 + " " + this.wypozyczenie.Model1 + " " + this.wypozyczenie.Nr_rejestracyjny;
            
        }

        private void buttton_zamknij_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
