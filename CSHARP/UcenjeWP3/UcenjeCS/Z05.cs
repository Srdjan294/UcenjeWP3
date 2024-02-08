using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        // program od korisnika unosi cijeli broj
        // program ispisuje zbroj svih brojeva od jedan do unesenog broja
        // primjer za 100 će ispisati 5050

        public static void Izvedi()
        {
            System.Console.WriteLine("Unesite neki cijeli broj: ");
            int x = int.Parse(Console.ReadLine());

            int suma = 0;

            for(int i = 0; i <= x; i++) {

                suma = suma + i;
            }

            Console.WriteLine(suma);
        }
    }
}
