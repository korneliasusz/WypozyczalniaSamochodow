using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Atrybut umożliwiający serializację klasy, mechanizm dziedziczenia
    /// Wykonanie Kornelia Susz
    /// </summary>
    [Serializable]
    public class SamochodDostawczy : Samochod
    {
        /// <summary>
        /// Zadefiniowanie pól klasy, określenie właściwości, dotępu, typu
        /// </summary>
        public double Tonaz;
        public double oplata_homologacyjna;
        /// <summary>
        /// Konstruktor nieparametryczny dziedziczący po klasie bazowej
        /// </summary>
        public SamochodDostawczy() : base()
        {
            Tonaz = 0.0;
            oplata_homologacyjna = 0.0;
        }

        /// <summary>
        /// Konstruktor parametryczny dziedziczący po klasie bazowej z zastosowaniem wyjąztku
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="rejestracyjny"></param>
        /// <param name="pojemnosc"></param>
        /// <param name="VIN"></param>
        /// <param name="silnik"></param>
        /// <param name="automat"></param>
        /// <param name="cena"></param>
        /// <param name="tonaz"></param>
        public SamochodDostawczy(string marka, string model, string rejestracyjny, double pojemnosc, string VIN, Rodzaj_Silnika silnik, bool automat, double cena, double tonaz) : base(marka, model, rejestracyjny, pojemnosc, VIN, silnik, automat, cena)
        {
            try
            {
                if (tonaz > 3.5 || tonaz < 0)
                {
                    throw (new ArgumentException());
                }
                Tonaz = tonaz;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Podano zbyt dużą ładowność.");
                Tonaz = 3.5;
            }
        }

        /// <summary>
        /// Metoda służąca do wypisywania zawartości dziedziczona po klasie bazowej, rozszerzona o potrzebne dane
        /// </summary>
        /// <returns>Tekst zawierający dane opisujące samochody dostawcze</returns>
        public override string ToString()
        {
            return base.ToString() + ", Ładowność: " + Tonaz + " ton" + ", Cena łącznie" + (Cena + oplata_homologacyjna);
        }
    }
}
