using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_Susz_Kulec_Koterwa;
using System;

namespace Testy
{
    /// <summary>
    /// Testy wykonane przez wszystkich cz³onków grupy razem
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod]
        [ExpectedException(typeof(WrongVINException))]
        public void NumerVIN()
        {
            Samochod s = new Samochod("Opel", "Astra", "SZY 876H5", 1.6, "W0LPE9E73G1130965", Samochod.Rodzaj_Silnika.hybryda, false, 70);
            Assert.ThrowsException<WrongVINException>(() => s.NR_VIN);
        }*/

        
        /// <summary>
        /// Zastêpowanie pustych pól w numerze VIN zerami
        /// </summary>
        [TestMethod]
        public void ZastapZerami()
        {
            Samochod s = new Samochod("Opel", "Astra", "SZY 876H5", 1.6, "W0LPE9G1130965", Samochod.Rodzaj_Silnika.hybryda, false, 70);
            Assert.ReplaceNullChars(s.NR_VIN);
        }

        /// <summary>
        /// Porównywanie dwóch samochodów ze wzglêdu na markê
        /// </summary>
        [TestMethod]
        public void TestCompare()
        {
            Samochod s4 = new Samochod("Renault", "Koleos", "SB L8AB2", 1.4, "VF1VY0K0NUC369508", Samochod.Rodzaj_Silnika.hybryda, false, 80);
            Samochod s11 = new Samochod("Renault", "Capture", "KR 58LP6", 1.6, "VF1KW0EB544466326", Samochod.Rodzaj_Silnika.diesel, false, 80);
            int i = s4.CompareTo(s11);
            Assert.AreEqual(1, i);
        }


        /// <summary>
        /// Sprawdzanie poprawnoœci danych osoby wypo¿yczaj¹cej oraz daty wypo¿yczenia
        /// </summary>
        [TestMethod]
        public void TestWypozyczajacego()
        {
            Wypozyczenie wypozyczenie_1 = new Wypozyczenie("Ford", "Focus", "SZY 844A2", 2.0, "WF0GXXGAJG8S53036", Samochod.Rodzaj_Silnika.diesel, false, 80, "2020-12-30", "2020-12-31", "Kowalski", "98765432103", "506-425-712");

            Assert.AreEqual("Kowalski", wypozyczenie_1.Nazwisko);
            Assert.AreEqual("98765432103", wypozyczenie_1.PESEL);
            Assert.AreEqual("2020-12-30", wypozyczenie_1.Data_Wypozyczenia.ToString("yyyy-MM-dd"));
        }

        /// <summary>
        /// Weryfikacja czy samochód jest wyposa¿ony w automatyczn¹ skrzyniê biegów
        /// </summary>
        [TestMethod]
        public void CzyAutmoat()
        {
            Samochod s24 = new Samochod("Peugeot", "508", "SB LS23X", 1.6, "VF3WA5FS09T062882", Samochod.Rodzaj_Silnika.benzyna, true, 90);
            Assert.IsTrue(s24.Automat);
        }


        /// <summary>
        /// Sprawdzenie czy pole numer telefonu nie jest puste
        /// </summary>
        [TestMethod]
        public void NumerTelefonu()
        {
            Wypozyczenie wypozyczenie_2 = new Wypozyczenie("Alfa Romeo", "Giulia", "KR 56N9S", 2.4, "ZAR93900007223697", Samochod.Rodzaj_Silnika.diesel, true, 100, "2020-12-30", "2020-12-31", "Nowak", "93128362192", "693-823-968");
            Assert.IsNotNull(wypozyczenie_2.Numer_kontaktowy);
        }

        /// <summary>
        /// Sprawdzenie czy nie wprowadzono dwukrotnie tego samego samochodu
        /// </summary>
        [TestMethod]
        public void CzyNieTakieSame()
        {
            Samochod s26 = new Samochod("Citroen", "C4", "WR WP2GF", 2.0, "VF7CHNFVK39628905", Samochod.Rodzaj_Silnika.diesel, false, 70);
            Samochod s30 = new Samochod("Honda", "Jazz", "SB 48HAP", 1.6, "SHHEU77402U033301", Samochod.Rodzaj_Silnika.benzyna, true, 80);
            Assert.AreNotSame(s26, s30);
        }
    }
}
