using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    // Jedna klasa može naslijediti samo jednu nadklasu
    internal class Predavac:Osoba   // Klasa Predavač nasljeđuje klasu osoba
    {
        public string? Iban { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ": " + Iban;
        }
    }
}
