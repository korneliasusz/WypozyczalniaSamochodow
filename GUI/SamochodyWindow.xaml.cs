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
    /// Logika interakcji dla klasy SamochodyWindow.xaml
    /// </summary>
    public partial class SamochodyWindow : Window
    {
        Wypozyczalnia wypozyczalnia = new Wypozyczalnia();
        ObservableCollection<Samochod> lista;
        
        /// <summary>
        /// konstruktor inicjalizujący okno i odczytujący dane z pliku XML
        /// </summary>
        public SamochodyWindow()
        {
            InitializeComponent();
            wypozyczalnia = (Wypozyczalnia)Wypozyczalnia.OdczytajXML("C:/Users/korne/Desktop/Studia/semestr 3/Programowanie obiektowe/Projekt_Susz_Kulec_Koterwa/Projekt_Susz_Kulec_Koterwa/bin/Debug/netcoreapp3.1/wypozyczalnia.xml");
            lista = new ObservableCollection<Samochod>(wypozyczalnia.samochody);
            listbox_samochody.ItemsSource = lista;
        }

        private void button_szczegoly_Click(object sender, RoutedEventArgs e)
        {
            int zaznaczony = listbox_samochody.SelectedIndex;
            SamochodWindow okno = new SamochodWindow(wypozyczalnia.samochody[zaznaczony]);
            okno.ShowDialog();
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            Samochod s = new Samochod();
            SamochodWindow okno = new SamochodWindow(s);
            okno.ShowDialog();
            wypozyczalnia.DodajSamochod(s);
            lista.Add(s);
        }

        private void button_usun_Click(object sender, RoutedEventArgs e)
        {
            int zaznaczony = listbox_samochody.SelectedIndex;
            
            MessageBoxResult messageBoxResult = MessageBox.Show("Czy na pewno chcesz usunąć ten samochód?", "Pytanie", MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                lista.RemoveAt(zaznaczony);
                wypozyczalnia.samochody.RemoveAt(zaznaczony);
            }
            
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
