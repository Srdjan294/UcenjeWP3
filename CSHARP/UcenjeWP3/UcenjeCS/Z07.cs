using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z07
    {
        // Prim broj (prost broj)

        public static void Izvedi()
        {
            Console.WriteLine("Unesi broj: ");
            int b = int.Parse(Console.ReadLine());

            bool prim = true;

            for(int i = 2; i < b; i++)
            {
                if(b%i == 0)
                {
                    prim = false;
                    break;  // za broj 2536562 si uštedio 2536561 iteraciju
                }
            }

            Console.WriteLine(b + " " + (prim ? " je " : " nije ") + "prim broj");
        }
    }
}
