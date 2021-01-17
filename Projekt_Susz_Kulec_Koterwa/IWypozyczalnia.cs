using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Interfejs zawierający wymagane metody dla klasy Wypożyczalnia zawierającej kolekcję
    /// Wykonanie Aleksander Kulec
    /// </summary>
    interface IWypozyczalnia
    {
        void DodajSamochod(Samochod s);
        bool UsunSamochod(string VIN);
        List<Samochod> ZnajdzMarke(string marka);
        Samochod ZnajdzSamochod(string numer);
    }
}
