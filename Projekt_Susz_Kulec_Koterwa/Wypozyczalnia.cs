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
    /// Atrybut umożliwiający serializację klasy
    /// Wykonanie Kornelia Susz
    /// </summary>
    [Serializable]
    public class Wypozyczalnia:Kopiowanie,IWypozyczalnia, ICloneable
    {
        /// <summary>
        /// Deklaracja odpowiednich kolekcji
        /// </summary>
        public List<Samochod> samochody;
        public List<Samochod> wypozyczone;
        public List<Samochod> dostepne;
        
        /// <summary>
        /// Konstruktor inicjalizujący wystąpienia kolekcji
        /// </summary>
        public Wypozyczalnia()
        {
            samochody = new List<Samochod>();
            wypozyczone = new List<Samochod>();
            dostepne = new List<Samochod>();
        }

        
        /// <summary>
        /// Metoda służąca do dodania samochodów do kolekcji
        /// </summary>
        /// <param name="s"></param>
        public void DodajSamochod(Samochod s)
        {
            samochody.Add(s);
            dostepne.Add(s);
        }

        /// <summary>
        /// Metoda służąca do usuwania samochodów o podanym numerze VIN z kolekcji
        /// </summary>
        /// <param name="VIN"></param>
        /// <returns>Prawdę, jeśli samochód został usunięty, fałsz, jeśli nie</returns>
        public bool UsunSamochod(string VIN)
        {
            foreach (Samochod s in samochody)
            {
                if (s.NR_VIN.Equals(VIN))
                {
                    samochody = new List<Samochod>(samochody.Where(x => x.NR_VIN != VIN));
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Metoda służąca do dodania samochodów do jeden listy i równoczesnego usunięcia z drugiej
        /// </summary>
        /// <param name="numer"></param>
        public void DodajWypozyczenie(string numer)
        {
            for (int i = 0; i < samochody.Count(); i++)
            {
                if (samochody.ElementAt(i).Nr_rejestracyjny.Equals(numer))
                {
                    dostepne = new List<Samochod>(dostepne.Where(x => x.Nr_rejestracyjny != numer));
                    wypozyczone.Add(samochody.ElementAt(i));
                }
            }
        }

        /// <summary>
        /// Metoda służąca do dodania samochodów do jednej listy i równoczesnego usunięcia z drugiej
        /// </summary>
        /// <param name="numer"></param>
        public void KoniecWypozycznia(string numer)
        {
            for (int i = 0; i < samochody.Count(); i++)
            {
                if (samochody.ElementAt(i).Nr_rejestracyjny.Equals(numer))
                {
                    dostepne.Add(samochody.ElementAt(i));
                    wypozyczone = new List<Samochod>(wypozyczone.Where(x => x.Nr_rejestracyjny != numer));
                }
            }
        }

        /// <summary>
        /// Metoda służąca do wyszukiwania samochodu po marce
        /// </summary>
        /// <param name="marka"></param>
        /// <returns>Lista samochodów o podanej marce</returns>
        public List<Samochod> ZnajdzMarke(string marka)
        {
            List<Samochod> lista = new List<Samochod>();

            for (int i = 0; i < samochody.Count(); i++)
            {
                if (samochody.ElementAt(i).Marka1 == marka)
                {
                    lista.Add(samochody.ElementAt(i));
                }
            }
            return lista;
        }

        /// <summary>
        /// Metoda służąca do wyszukiwania samochodu po numerze wewnętrznym
        /// </summary>
        /// <param name="numer"></param>
        /// <returns>Samochód o podanym numerze wewnętrznym</returns>
        public Samochod ZnajdzSamochod(string numer)
        {
            for (int i = 0; i < samochody.Count(); i++)
            {
                if (samochody.ElementAt(i).Nr_rejestracyjny.Equals(numer))
                {
                    return samochody.ElementAt(i);
                }
            }
            return null;
        }


        /// <summary>
        /// Metoda służąca do serializacji klasy do pliku xml
        /// </summary>
        /// <param name="nazwa"></param>
        /// <param name="w"></param>
        public void ZapiszXML(string nazwa, Wypozyczalnia w)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Wypozyczalnia));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, w);
            writer.Close();
        }

        /// <summary>
        /// Metoda służąca do deserializacji klasy z pliku xml
        /// </summary>
        /// <param name="nazwa"></param>
        /// <returns>Odczytane dane z pliku XML</returns>
        public static Wypozyczalnia OdczytajXML(string nazwa)
        {
            try
            {                
                StreamReader reader = new StreamReader(nazwa);
                XmlSerializer serializer = new XmlSerializer(typeof(Wypozyczalnia));
                Wypozyczalnia odczytana = (Wypozyczalnia)serializer.Deserialize(reader);
                reader.Close();
                return odczytana;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Plik {nazwa} nie istnieje");
            }
            return null;
        }

        /// <summary>
        /// Metoda sortująca samochody alfabetycznie
        /// </summary>
        public void Sortuj()
        {
            List<Samochod> sortowanie = new List<Samochod>(samochody);
            sortowanie.Sort();
            foreach (Samochod s in sortowanie)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// Metoda służąca do kopiowania
        /// </summary>
        /// <returns>Kopia klasy</returns>
       new public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Kopia głęboka klasy
        /// </summary>
        /// <returns>Kopia głęboka klasy</returns>
        public Wypozyczalnia DeepCopy()
        {
            Wypozyczalnia kopia = (Wypozyczalnia)this.Clone();
            return kopia;
        }

        /// <summary>
        /// Metoda służąca do wypisywania zawartości klasy z użyciem StringBuildera
        /// </summary>
        /// <returns>Tekst zawierający zawartość wypożyczalnii</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista wszystkich samochodów:");
            foreach (Samochod s in samochody)
            {
                sb.AppendLine(s.ToString());
            }
            sb.AppendLine();
            sb.AppendLine("Wypożyczone:");
            foreach (Samochod s in wypozyczone)
            {
                sb.AppendLine(s.ToString());
            }
            sb.AppendLine();
            sb.AppendLine("Dostępne:");
            foreach (Samochod s in dostepne)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }
    }
}
