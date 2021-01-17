using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Media;
using System.IO;
using System.Xml.Serialization;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Atrybut umożliwiający serializację klasy, mechanizm dziedziczenia
    /// Wykonanie Jan Koterwa
    /// </summary>
    [Serializable]
    public class Wypozyczenia:Wypozyczenie
    {
        /// <summary>
        /// Deklaracja odpowiednich kolekcji
        /// </summary>
        public LinkedList<Wypozyczenie> wypozyczenia;

        /// <summary>
        /// Konstruktor inicjalizujący wystąpienia kolekcji
        /// </summary>
        public Wypozyczenia()
        {
            wypozyczenia = new LinkedList<Wypozyczenie>();
        }

        /// <summary>
        /// Metoda służąca do dodawania nowego wypożyczenia do kolekcji
        /// </summary>
        /// <param name="w"></param>
        public void DodajWypozyczenie(Wypozyczenie w)
        {
            wypozyczenia.AddLast(w);
        }

        /// <summary>
        /// Metoda służąca do serializacji klasy do pliku binarnego
        /// </summary>
        /// <param name="nazwa"></param>
        public void ZapiszBin(string nazwa)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(nazwa, FileMode.Create);
            bf.Serialize(fs, this);
            fs.Close();
        }

        /// <summary>
        /// Metoda służąca do deserializacji klasy z pliku binarnego
        /// </summary>
        /// <param name="nazwa"></param>
        /// <returns>Odczytane dane z pliku binarnego</returns>
        public static object OdczytajBin(string nazwa)
        {
            Wypozyczenia odczytane;
            try
            {
                FileStream fs = new FileStream(nazwa, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                odczytane = (Wypozyczenia)bf.Deserialize(fs);
                fs.Close();
                return odczytane;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Plik {nazwa} nie istnieje");
            }
            return null;
        }

        /// <summary>
        /// Metoda służąca do wypisywania zawartości klasy z użyciem StringBuildera
        /// </summary>
        /// <returns>Tekst zawierający listę wypożyczeń</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Wypożyczenia");
            foreach(Wypozyczenie w in wypozyczenia)
            {
                sb.AppendLine(w.ToString());
            }
            return sb.ToString();

        }
    }
}
