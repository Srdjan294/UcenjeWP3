using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            // Program unosi tri cijela broja
            // program ispisuje najmanji

            Console.WriteLine("Unesi 1. broj: ");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 3. broj: ");
            int treciBroj = int.Parse(Console.ReadLine());

            if((prviBroj < drugiBroj) && (prviBroj < treciBroj)){
                Console.WriteLine(prviBroj + " je najmanji");
            }else if((drugiBroj < prviBroj) && (drugiBroj < treciBroj)){
                Console.WriteLine(drugiBroj + " je najmanji");
            }else
            {
                Console.WriteLine(treciBroj + " je najmanji");
            }
            {
               
            }
    {

    }
        }
    }
}
