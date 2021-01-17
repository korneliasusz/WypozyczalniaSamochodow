using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Atrybuty umożliwiające serializację klasy
    /// Wykonanie Aleksander Kulec
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(SamochodDostawczy))]

    public class Samochod : IComparable
    {
        /// <summary>
        /// Zadefiniowanie pól klasy, określenie właściwości, dotępu, typu
        /// </summary>
        public static int Licznik = 1;
        private string Marka;
        private string Model;
        public string Marka1 { get => Marka; set => Marka = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string NR_VIN;
        /// <summary>
        /// Definicja enumeracji
        /// </summary>
        public enum Rodzaj_Silnika
        {
            benzyna, gaz, diesel, hybryda, hybryda_plug_in
        };
        public Rodzaj_Silnika Silnik;
        public double Pojemnosc_Silnika;
        public string Wewnetrzny_nr_ID;
        public string Nr_rejestracyjny;
        public bool Automat;
        public double Cena;
        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Samochod()
        {
            Marka1 = null;
            Model1 = null;
            Pojemnosc_Silnika = 0;
            Nr_rejestracyjny = null;
            NR_VIN = null;
            Automat = false;
            Cena = 0.0;
        }

        /// <summary>
        /// Konstruktor parametryczny, w którym zastosowany jest wyjątek oraz ustawianie napisu składającego się z określonych części zmiennych
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="rejestracyjny"></param>
        /// <param name="pojemnosc"></param>
        /// <param name="VIN"></param>
        /// <param name="silnik"></param>
        /// <param name="automat"></param>
        /// <param name="cena"></param>
        public Samochod(string marka, string model, string rejestracyjny, double pojemnosc, string VIN, Rodzaj_Silnika silnik, bool automat, double cena)
        {
            Marka1 = marka;
            Model1 = model;
            Nr_rejestracyjny = rejestracyjny;
            Pojemnosc_Silnika = pojemnosc;

            try
            {
                if (VIN.Length != 17)
                {
                    throw (new WrongVINException());

                }
                NR_VIN = VIN;
            }
            catch (WrongVINException e)
            {
                Console.WriteLine(e.Message);
                NR_VIN = new String('0', 17);
            }

            Cena = cena;
            Silnik = silnik;
            Automat = automat;
            Wewnetrzny_nr_ID = Marka1[0].ToString() + Model1[0].ToString() + NR_VIN[0] + NR_VIN[1] + NR_VIN[2] + Licznik.ToString("D3");
            Licznik++;
        }

        /// <summary>
        /// Konstruktor parametryczny potrzebny do użycia w innej klasie
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="nr_rejestr"></param>
        public Samochod(string marka, string model, string nr_rejestr) : this()
        {
            Marka1 = marka;
            Model1 = model;
            Nr_rejestracyjny = nr_rejestr;
        }

        /// <summary>
        /// Metoda służąca do wypisywania zawartości
        /// </summary>
        /// <returns>Tekst zawierający dane opisujące samochody</returns>
        public override string ToString()
        {
            if (Automat == true)
                return ($"{Wewnetrzny_nr_ID} {Marka1} {Model1} (numer rejestracyjny: {Nr_rejestracyjny} --- numer VIN: {NR_VIN} --- skrzynia biegów: automatyczna --- silnik: {Silnik} {Pojemnosc_Silnika}l)");
            else
                return ($"{Wewnetrzny_nr_ID} {Marka1} {Model1} (numer rejestracyjny: {Nr_rejestracyjny} --- numer VIN: {NR_VIN} --- skrzynia biegów: manualna --- silnik: {Silnik} {Pojemnosc_Silnika}l)");
        }

        /// <summary>
        /// Metoda służąca do porównywania obiektów klasy
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                Samochod s = (Samochod)obj;
                int cmp = this.Marka.CompareTo(s.Marka);
                if (cmp != 0)
                    return cmp;
                else
                    return this.Model1.CompareTo(s.Model1);
            }
            else
                return 1;
        }
    }
}
