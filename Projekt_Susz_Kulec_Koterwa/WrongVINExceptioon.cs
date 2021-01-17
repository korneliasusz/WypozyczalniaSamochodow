using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Klasa obsługująca wyjątek dotyczący poprawności podanego numeru VIN samochodu dziedzicząca po wbudowanej klasie Exception
    /// Wykonanie Jan Koterwa
    /// </summary>
    public class WrongVINException:Exception
    {
        public WrongVINException(): base()
        {
            Console.WriteLine("Niepoprawny numer VIN");
        }
    }
}
