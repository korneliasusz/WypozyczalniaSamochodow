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
    /// Logika interakcji dla klasy DostepneWindow.xaml
    /// </summary>
    public partial class DostepneWindow : Window
    {
        Wypozyczalnia wypozyczalnia = new Wypozyczalnia();
        ObservableCollection<Samochod> lista;

        public DostepneWindow()
        {
            InitializeComponent();
            wypozyczalnia = (Wypozyczalnia)Wypozyczalnia.OdczytajXML("C:/Users/korne/Desktop/Studia/semestr 3/Programowanie obiektowe/Projekt_Susz_Kulec_Koterwa/Projekt_Susz_Kulec_Koterwa/bin/Debug/netcoreapp3.1/wypozyczalnia.xml");
            lista = new ObservableCollection<Samochod>(wypozyczalnia.dostepne);
            listbox_dostepne.ItemsSource = lista;
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
