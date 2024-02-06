using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04
    {

        // program od korisnika unosi dva broja
        // program ispisuje sve neparne brojeve
        // između dva unesena broja 

        public static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj: ");
            int y = int.Parse(Console.ReadLine());
            int manji = x < y ? x : y;
            int veci = x > y ? x : y;
            for(int i = manji; i <= veci; i++) 
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
