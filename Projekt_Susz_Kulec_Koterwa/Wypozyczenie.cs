using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Atrybut umożliwiający serializację klasy, mechanizm dziedziczenia
    /// Wykonanie Jan Koterwa
    /// </summary>
    [Serializable]
    public class Wypozyczenie : Samochod
    {
        /// <summary>
        /// Zadefiniowanie pól klasy, określenie właściwości, dotępu, typu
        /// </summary>
        public DateTime Data_Wypozyczenia;
        public DateTime Data_Oddania;
        public string Nazwisko;
        public string PESEL;
        public string Numer_kontaktowy;
        public double Koszt;

        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Wypozyczenie() : base()
        {
            Data_Wypozyczenia = DateTime.MinValue;
            Data_Oddania = DateTime.MinValue;
            Nazwisko = null;
            PESEL = null;
            Numer_kontaktowy = null;
        }

        /// <summary>
        /// Konstruktor parametryczny z wykorzystaniem wyjątku
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="rejestracyjny"></param>
        /// <param name="pojemnosc"></param>
        /// <param name="VIN"></param>
        /// <param name="silnik"></param>
        /// <param name="automat"></param>
        /// <param name="cena"></param>
        /// <param name="data_wypoz"></param>
        /// <param name="data_oddania"></param>
        /// <param name="nazwisko"></param>
        /// <param name="pesel"></param>
        /// <param name="numer"></param>
        public Wypozyczenie(string marka, string model, string rejestracyjny, double pojemnosc, string VIN, Rodzaj_Silnika silnik, bool automat, double cena, string data_wypoz, string data_oddania, string nazwisko, string pesel, string numer) : base(marka, model, rejestracyjny, pojemnosc, VIN, silnik, automat, cena)
        {
            DateTime.TryParseExact(data_wypoz, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, DateTimeStyles.None, out Data_Wypozyczenia);
            DateTime.TryParseExact(data_oddania, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, DateTimeStyles.None, out Data_Oddania);
            try
            {
                if (Data_Oddania < Data_Wypozyczenia)
                {
                    throw new WrongDateException();
                }
            }
            catch (WrongDateException e)
            {
                Console.WriteLine(e.Message);
                Data_Oddania = Data_Wypozyczenia;
            }

            Nazwisko = nazwisko;
            PESEL = pesel;
            Numer_kontaktowy = numer;
        }

        /// <summary>
        /// Metoda obliczająca koszt wypożyczenia
        /// </summary>
        /// <returns>Koszt wypożyczenia</returns>
        public double KosztWypozyczenia()
        {

            TimeSpan x = Data_Oddania - Data_Wypozyczenia;
            double dni = x.TotalDays;

            if (Silnik.Equals(Rodzaj_Silnika.benzyna))             // opłata emisyjna
            {
                Koszt = dni * Cena + 4;
            }
            else if (Silnik.Equals(Rodzaj_Silnika.diesel))         //opłata emisyjna
            {
                Koszt = dni * Cena + 8;
            }
            else
            {
                Koszt = dni * Cena;
            }

            return Koszt;
        }

        /// <summary>
        /// Metoda służąca do wypisywania zawartości dziedziczona po klasie bazowej, rozszerzona o potrzebne dane
        /// </summary>
        /// <returns>Tekst zawierający informacje o wypożyczeniach</returns>
        public override string ToString()
        {
            return $"{Marka1} {Model1} (numer rejestracyjny: {Nr_rejestracyjny} --- klient: {Nazwisko} --- numer telefonu: {Numer_kontaktowy} --- Koszt wypożyczenia: {KosztWypozyczenia().ToString("C")})";
        }
    }
}
