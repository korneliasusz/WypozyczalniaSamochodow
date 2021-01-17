using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Susz_Kulec_Koterwa
{
    /// <summary>
    /// Klasa abstrakcyjna implementująca metodę kopiowania
    /// Wykonanie Aleksander Kulec
    /// </summary>
   public abstract class Kopiowanie
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
