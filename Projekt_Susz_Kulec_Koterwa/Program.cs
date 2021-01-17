using System;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Program główny służący do testowania metod, sprawdzania poprawności programu
    /// </summary>

    class Program
    {


        static void Main(string[] args)
        {

            Samochod s1 = new Samochod("Volkswagen", "Passat", "SB 37281", 1.6, "WVGZZZ1TZ6W059812", Samochod.Rodzaj_Silnika.benzyna, true, 80);
            Samochod s2 = new Samochod("Ford", "Focus", "SZY 844A2", 2.0, "WF0GXXGAJG8S53036", Samochod.Rodzaj_Silnika.diesel, false, 80);
            Samochod s3 = new Samochod("Audi", "A4", "KR 9A6FD", 3.0, "WAUZZZ8LZYA111887", Samochod.Rodzaj_Silnika.benzyna, true, 110);
            Samochod s4 = new Samochod("Renault", "Koleos", "SB L8AB2", 1.4, "VF1VY0K0NUC369508", Samochod.Rodzaj_Silnika.hybryda, false, 80);
            Samochod s5 = new Samochod("Opel", "Astra", "SZY 876H5", 1.6, "W0LPE9E73G1130965", Samochod.Rodzaj_Silnika.hybryda, false, 70);
            Samochod s6 = new Samochod("Nissan", "Micra", "WR 352F1", 1.2, "SJN2EAK12U6021035", Samochod.Rodzaj_Silnika.gaz, false, 50);
            Samochod s7 = new Samochod("Toyota", "Auris", "KR 7GHB3", 1.6, "JTDZN3EU6EJ009258", Samochod.Rodzaj_Silnika.benzyna, true, 60);
            Samochod s8 = new Samochod("Hyundai", "Tucson", "SB 83FG3", 2.0, "KMHK3811AKU185593", Samochod.Rodzaj_Silnika.diesel, true, 80);
            Samochod s9 = new Samochod("Renault", "Megane", "SB 9PO2A", 1.8, "VF1HJD20662311853", Samochod.Rodzaj_Silnika.hybryda, false, 80);
            Samochod s10 = new Samochod("Alfa Romeo", "Giulia", "KR 56N9S", 2.4, "ZAR93900007223697", Samochod.Rodzaj_Silnika.diesel, true, 100);
            Samochod s11 = new Samochod("Renault", "Capture", "KR 58LP6", 1.6, "VF1KW0EB544466326", Samochod.Rodzaj_Silnika.diesel, false, 80);
            Samochod s12 = new Samochod("Fiat", "Punto", "SZY 5746D", 1.2, "ZFA19900000348501", Samochod.Rodzaj_Silnika.hybryda, false, 60);
            Samochod s13 = new Samochod("Alfa Romeo", "Stelvio", "SB P6S5D", 2.0, "ZAR94000007125988", Samochod.Rodzaj_Silnika.hybryda, true, 100);
            Samochod s14 = new Samochod("Volkswagen", "Golf", "SB 93BP1", 1.6, "3VWTT7AU3FM061005", Samochod.Rodzaj_Silnika.benzyna, true, 70);
            Samochod s15 = new Samochod("Renault", "Clio", "WR 23SZ1", 1.4, "VF1HJD20262518238", Samochod.Rodzaj_Silnika.diesel, false, 60);
            Samochod s16 = new Samochod("Nissan", "Juke", "WR LI83S", 2.0, "VWASHTF24B2125219", Samochod.Rodzaj_Silnika.diesel, false, 80);
            Samochod s17 = new Samochod("Hyundai", "Kona", "KR WI3D1", 1.8, "5NPD84LF1LH510740", Samochod.Rodzaj_Silnika.hybryda, true, 70);
            Samochod s18 = new Samochod("Nissan", "Qashqai", "SZY 482H2", 1.8, "SJNFBNJ10U1128767", Samochod.Rodzaj_Silnika.diesel, false, 90);
            Samochod s19 = new Samochod("Hyundai", "Tucson", "KR K4G52", 2.0, "TMADB51CAAJ103242", Samochod.Rodzaj_Silnika.diesel, false, 90);
            Samochod s20 = new Samochod("Toyota", "Auris", "SB 3L25K", 1.6, "VNKKL0D350A097704", Samochod.Rodzaj_Silnika.benzyna, true, 60);
            Samochod s21 = new Samochod("Peugeot", "308", "KR O36NA", 1.6, "VF3WC9HXC34140056", Samochod.Rodzaj_Silnika.diesel, false, 80);
            Samochod s22 = new Samochod("Mazda", "CX3", "SZY 95HB3", 1.2, "JMZGHA2B611493065", Samochod.Rodzaj_Silnika.hybryda, false, 90);
            Samochod s23 = new Samochod("Skoda", "Fabia", "SB 39D5A", 2.0, "TMBCE21UX32685192", Samochod.Rodzaj_Silnika.diesel, true, 70);
            Samochod s24 = new Samochod("Peugeot", "508", "SB LS23X", 1.6, "VF3WA5FS09T062882", Samochod.Rodzaj_Silnika.benzyna, true, 90);
            Samochod s25 = new Samochod("Skoda", "Caroq", "WR OL4MS", 1.4, "TMBCL63U079018283", Samochod.Rodzaj_Silnika.benzyna, false, 80);
            Samochod s26 = new Samochod("Citroen", "C4", "WR WP2GF", 2.0, "VF7CHNFVK39628905", Samochod.Rodzaj_Silnika.diesel, false, 70);
            Samochod s27 = new Samochod("Skoda", "Superb", "KR P2AL2", 1.8, "TMBJM25J9C3069603", Samochod.Rodzaj_Silnika.benzyna, true, 90);
            Samochod s28 = new Samochod("Honda", "Civic", "SZY 82DS0", 1.8, "SHSRE6750BU005457", Samochod.Rodzaj_Silnika.diesel, false, 70);
            Samochod s29 = new Samochod("Citroen", "DS3", "KR HR6UC", 2.0, "VF7RERHRJ76743413", Samochod.Rodzaj_Silnika.diesel, false, 80);
            Samochod s30 = new Samochod("Honda", "Jazz", "SB 48HAP", 1.6, "SHHEU77402U033301", Samochod.Rodzaj_Silnika.benzyna, true, 80);
            SamochodDostawczy s31 = new SamochodDostawczy("Renault", "Master", "SB 83GFQ", 1.6, "VF1JZ1U0247684068", Samochod.Rodzaj_Silnika.benzyna, false, 130, 3.0);
            SamochodDostawczy s32 = new SamochodDostawczy("Mercedes", "Sprinter", "KR 316G5", 1.8, "WDC1641771A140840", Samochod.Rodzaj_Silnika.diesel, true, 150, 3.5);
            SamochodDostawczy s33 = new SamochodDostawczy("Ford", "Transit", "KR 493AJ", 2.2, "WF0MXXGBWM8Y86210", Samochod.Rodzaj_Silnika.diesel, true, 110, 2.5);
            SamochodDostawczy s34 = new SamochodDostawczy("Peugeot", "Boxer", "WR K8F6V", 1.6, "VF3CCHNZ6GT020295", Samochod.Rodzaj_Silnika.gaz, true, 120, 2.5);
            SamochodDostawczy s35 = new SamochodDostawczy("Fiat", "Ducato", "WR 103F8", 1.8, "ZFA19800004161986", Samochod.Rodzaj_Silnika.benzyna, false, 120, 3.0);

            Wypozyczalnia wypozyczalnia = new Wypozyczalnia();

            wypozyczalnia.DodajSamochod(s1);
            wypozyczalnia.DodajSamochod(s2);
            wypozyczalnia.DodajSamochod(s3);
            wypozyczalnia.DodajSamochod(s4);
            wypozyczalnia.DodajSamochod(s5);
            wypozyczalnia.DodajSamochod(s6);
            wypozyczalnia.DodajSamochod(s7);
            wypozyczalnia.DodajSamochod(s8);
            wypozyczalnia.DodajSamochod(s9);
            wypozyczalnia.DodajSamochod(s10);
            wypozyczalnia.DodajSamochod(s11);
            wypozyczalnia.DodajSamochod(s12);
            wypozyczalnia.DodajSamochod(s13);
            wypozyczalnia.DodajSamochod(s14);
            wypozyczalnia.DodajSamochod(s15);
            wypozyczalnia.DodajSamochod(s16);
            wypozyczalnia.DodajSamochod(s17);
            wypozyczalnia.DodajSamochod(s18);
            wypozyczalnia.DodajSamochod(s19);
            wypozyczalnia.DodajSamochod(s20);
            wypozyczalnia.DodajSamochod(s21);
            wypozyczalnia.DodajSamochod(s22);
            wypozyczalnia.DodajSamochod(s23);
            wypozyczalnia.DodajSamochod(s24);
            wypozyczalnia.DodajSamochod(s25);
            wypozyczalnia.DodajSamochod(s26);
            wypozyczalnia.DodajSamochod(s27);
            wypozyczalnia.DodajSamochod(s28);
            wypozyczalnia.DodajSamochod(s29);
            wypozyczalnia.DodajSamochod(s30);
            wypozyczalnia.DodajSamochod(s31);
            wypozyczalnia.DodajSamochod(s32);
            wypozyczalnia.DodajSamochod(s33);
            wypozyczalnia.DodajSamochod(s34);
            wypozyczalnia.DodajSamochod(s35);

            Console.WriteLine("Czy udało się usunąć samochód o numerze VIN SHHEU77402U033301? " + wypozyczalnia.UsunSamochod("SHHEU77402U033301"));
            Console.WriteLine("Czy udało się usunąć samochód o numerze VIN VF1HJD20662311853? " + wypozyczalnia.UsunSamochod("VF1HJD20662311853"));


            Console.WriteLine(wypozyczalnia);
            Console.WriteLine();

            wypozyczalnia.Sortuj();

            Console.WriteLine("KOPIA");
            Wypozyczalnia wkopia = wypozyczalnia.DeepCopy();
            Console.WriteLine(wkopia);

            Console.WriteLine("Wypożyczone samochody:\n");
            Wypozyczenie wypozyczenie_1 = new Wypozyczenie("Ford", "Focus", "SZY 844A2", 2.0, "WF0GXXGAJG8S53036", Samochod.Rodzaj_Silnika.diesel, false, 80, "2020-12-30", "2020-12-31", "Kowalski", "98765432103", "506-425-712");
            Wypozyczenie wypozyczenie_2 = new Wypozyczenie("Alfa Romeo", "Giulia", "KR 56N9S", 2.4, "ZAR93900007223697", Samochod.Rodzaj_Silnika.diesel, true, 100, "2020-12-30", "2020-12-31", "Nowak", "93128362192", "693-823-968");
            Wypozyczenie wypozyczenie_3 = new Wypozyczenie("Fiat", "Ducato", "WR 103F8", 1.8, "ZFA19800004161986", Samochod.Rodzaj_Silnika.benzyna, false, 120, "2021-01-03", "2021-01-10", "Piątek", "87451296587", "666-888-111");
            Wypozyczenie wypozyczenie_4 = new Wypozyczenie("Peugeot", "508", "SB LS23X", 1.6, "VF3WA5FS09T062882", Samochod.Rodzaj_Silnika.benzyna, true, 90, "2020-12-26", "2021-01-05", "Bratek", "74892015369", "679-874-541");
            Wypozyczenie wypozyczenie_5 = new Wypozyczenie("Volkswagen", "Passat", "SB 37281", 1.6, "WVGZZZ1TZ6W059812", Samochod.Rodzaj_Silnika.benzyna, true, 80, "2020-12-30", "2020-12-31", "Pies", "99124785962", "978-823-968");
            Wypozyczenie wypozyczenie_6 = new Wypozyczenie("Citroen", "DS3", "KR HR6UC", 2.0, "VF7RERHRJ76743413", Samochod.Rodzaj_Silnika.diesel, false, 80, "2020-12-10", "2020-12-21", "Krok", "87598147520", "541-702-987");


            Console.WriteLine("DODAWANIE USUWANIE WYPOZYCZEN");
            wypozyczalnia.DodajWypozyczenie("SZY 844A2");
            wypozyczalnia.DodajWypozyczenie("KR 56N9S");
            wypozyczalnia.DodajWypozyczenie("WR 103F8");
            wypozyczalnia.DodajWypozyczenie("SB LS23X");
            wypozyczalnia.DodajWypozyczenie("SB 37281");
            wypozyczalnia.DodajWypozyczenie("KR HR6UC");

            Console.WriteLine(wypozyczalnia);

            wypozyczalnia.ZapiszXML("wypozyczalnia.xml", wypozyczalnia);
            Console.WriteLine("\nZAPISANO XML");
            Console.WriteLine("\nODCZYT XML" + Wypozyczalnia.OdczytajXML("wypozyczalnia.xml"));

            wypozyczalnia.KoniecWypozycznia("SZY 844A2");
            Console.WriteLine(wypozyczalnia);

            Wypozyczenia wszystkie_wypozyczenia = new Wypozyczenia();
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_2);
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_1);
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_3);
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_4);
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_5);
            wszystkie_wypozyczenia.DodajWypozyczenie(wypozyczenie_6);

            Console.WriteLine(wszystkie_wypozyczenia);

            wszystkie_wypozyczenia.ZapiszBin("wypozyczenia.bin");
            Console.WriteLine("ZAPISANO BIN");
            Console.WriteLine(Wypozyczenia.OdczytajBin("wypozyczenia.bin"));

            Console.WriteLine("Samochody o marce Toyota:");
            foreach (var item in wypozyczalnia.ZnajdzMarke("Toyota"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWyszukiwanie samochodu o podanym numerze rejestracyjnym");
            Console.WriteLine(wypozyczalnia.ZnajdzSamochod("KR 58LP6"));
        }
    }

}