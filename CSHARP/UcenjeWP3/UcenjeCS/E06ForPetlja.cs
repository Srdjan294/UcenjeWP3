using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {

        public static void Izvedi()
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine("Edunova " + i);

            }


            int[] niz = { 1, 2, 3, 44, 5, 6, 7, 8, 9 };

            // ispiati sve brojeve jedne ispod drugih

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            // ispisati sve parne brojeve od 3 do 43

            for (int i = 3; i <= 43; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }



            // koji je zbroj prvih 100 brojeva
            // 1+2+3+4+...+98+99+100

            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);

            // petlja može ići i unazad
            // ispiši sve brojeve od 78 i 4
            for (int i = 78; i >= 4; i--)
            {
                Console.WriteLine(i);
            }

            // korak može biti koji god mi želimo
            // ispiši svaki sedmi broj od 1 do 100

            for (int i = 1; i <= 100; i += 7)
            {
                Console.WriteLine(i);
            }

            // ovaj način nećemo koristiti
            //int j;
            //for(j = 0; j < 10; j++){

            //}

            // ispišite brojeve od 1 do 20 jedno pokraj drugog
            for(int i = 1; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("************************");

            // petlje se mogu ugnijezditi

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("\t" + i*j + " ");
                }
                Console.WriteLine();
            }

            // Petlja se može preskočiti odnosno nastaviti

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;  // shortcircuiting, preskače 3
                }

                Console.WriteLine(i);
            }

            // petlja se može nasilno prekinuti

            for(int i = 0; i < 10; i++)
            {
                if(i == 3)
                {
                    break;   // nakon trojke izlaz iz petlje
                }

                Console.WriteLine(i);
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    // kako prekinuti vanjsku petlju (varijabla i)
                    goto labela;  // break onda ne treba
                    //break;  // prekidam unutarnju petlju (varijabla j)
                    
                }
            }

            labela:
            Console.WriteLine("nastavljam nakon vanjske petlje");

            // beskonačna petlja

            for (; ; )
            {
                Console.WriteLine(new Random().NextInt64(1, 100));
                break;
            }





        }
    }
}
