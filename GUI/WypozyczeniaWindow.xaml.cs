using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    /// Logika interakcji dla klasy WypozyczeniaWindow.xaml
    /// </summary>
    public partial class WypozyczeniaWindow : Window
    {
        Wypozyczenia wypozycz;
        ObservableCollection<Wypozyczenie> lista;
        public WypozyczeniaWindow()
        {
            InitializeComponent();
            wypozycz = (Wypozyczenia)Wypozyczenia.OdczytajBin("C:/Users/korne/Desktop/Studia/semestr 3/Programowanie obiektowe/Projekt_Susz_Kulec_Koterwa/Projekt_Susz_Kulec_Koterwa/bin/Debug/netcoreapp3.1/wypozyczenia.bin");
            lista = new ObservableCollection<Wypozyczenie>(wypozycz.wypozyczenia);
            listbox_wypozyczenia.ItemsSource = lista;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_szczegoly_Click(object sender, RoutedEventArgs e)
        {
            int zaznaczony = listbox_wypozyczenia.SelectedIndex;
            WypozyczenieWindow okno = new WypozyczenieWindow(wypozycz.wypozyczenia.ElementAt(zaznaczony));
            okno.ShowDialog();
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
