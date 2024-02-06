using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02
    {
        public static void Izvedi()
        {
            // Program unosi dva broja
            // Ispisuje veći

            Console.WriteLine("Unesi dva broja: ");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x);
            }
            else if (x == y){
                
                Console.WriteLine("Brojevi su jednaki");
            }
            else
            {
                Console.WriteLine(y);
            }
        }
    }
}
