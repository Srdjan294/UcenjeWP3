using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z09
    {
        // Program unosi ime osobe, visinu i težinu
        // program ispisuje crvenom bojom
        // ako je visina > 170 i i < 190 te težina je < 90,5
        // Ti, xxxx si zgodan / zgodna

        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi ime osobe");

            int visina = Pomocno.UcitajCijeliBroj("Unesi visinu u cm");

            float tezina = Pomocno.UcitajDecimalniBroj("Unesi težinu");

            if(visina > 170 && visina < 190 && tezina < 90.5){
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ime[^1] == 'a' ? "zgodna si " + ime: "zgodan si " + ime);
                
                Console.ResetColor();
            }
        }
    }
}
