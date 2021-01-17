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

        private void button_filtruj_Click(object sender, RoutedEventArgs e)
        {
            if (cmbbox_marka.Text == "Toyota")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Toyota"));
            }
            else if(cmbbox_marka.Text == "Ford")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Ford"));
            }
            else if (cmbbox_marka.Text == "Volkswagen")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Volkswagen"));
            }
            else if (cmbbox_marka.Text == "Audi")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Audi"));
            }
            else if (cmbbox_marka.Text == "Renault")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Renault"));
            }
            else if (cmbbox_marka.Text == "Opel")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Opel"));
            }
            else if (cmbbox_marka.Text == "Nissan")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Nissan"));
            }
            else if (cmbbox_marka.Text == "Fiat")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Fiat"));
            }
            else if (cmbbox_marka.Text == "Hyundai")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Hyundai"));
            }
            else if (cmbbox_marka.Text == "Skoda")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Skoda"));
            }
            else if (cmbbox_marka.Text == "Alfa Romeo")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Alfa Romeo"));
            }
            else if (cmbbox_marka.Text == "Citroen")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Citroen"));
            }
            else if (cmbbox_marka.Text == "Mercedes")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Mercedes"));
            }
            else if (cmbbox_marka.Text == "Honda")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Honda"));
            }
            else if (cmbbox_marka.Text == "Mazda")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Mazda"));
            }
            else if (cmbbox_marka.Text == "Wszystkie")
            {
                listbox_samochody.ItemsSource = lista;
            }
            else if (cmbbox_marka.Text == "Peugeot")
            {
                listbox_samochody.ItemsSource = lista.Where(x => x.Marka1.Equals("Peugeot"));
            }
        }
    }
}
