using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projekt_Susz_Kulec_Koterwa;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_samochody_Click(object sender, RoutedEventArgs e)
        {
            SamochodyWindow okno = new SamochodyWindow();
            okno.ShowDialog();
        }

        private void button_dostepne_Click(object sender, RoutedEventArgs e)
        {
            DostepneWindow okno = new DostepneWindow();
            okno.ShowDialog();
        }

        private void button_wypozyczone_Click(object sender, RoutedEventArgs e)
        {
            WypozyczoneWindow okno = new WypozyczoneWindow();
            okno.ShowDialog();
        }

        private void button_wypozyczenia_Click(object sender, RoutedEventArgs e)
        {
            WypozyczeniaWindow okno = new WypozyczeniaWindow();
            okno.ShowDialog();
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
