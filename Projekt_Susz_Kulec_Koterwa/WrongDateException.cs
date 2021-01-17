using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Klasa obsługująca wyjątek dotyczący poprawności podanych dat dziedzicząca po wbudowanej klasie Exception
    /// Wykonanie Aleksander Kulec
    /// </summary>
    class WrongDateException :Exception
    {
        public WrongDateException() : base()
        {
            Console.WriteLine("Niepoprawna data");
        }
    }
}
