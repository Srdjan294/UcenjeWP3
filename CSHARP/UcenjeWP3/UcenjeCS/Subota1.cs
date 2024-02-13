using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Subota1
    {
        public static void Izvedi() { 
        
            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds());
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine("\a");
                //Thread.Sleep(1000);  // usporavanje rada programa  -  spavaj jednu sekundu
            }

            int t = 2147483647;

            long l = (long)t + 1;  // implicitno 

            l = 2147483647433453;

            Console.WriteLine(l);

            t = (int)l;  // eksplicitno

            Console.WriteLine(t);


            // Program unosi tri cijela broja i ispisuje ih jedan pored drugog

            //Console.WriteLine("Unesi tri cijela broja: ");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());

            //Console.WriteLine(x + " " + y + " " + z);


            // Program unosi imena triju gradova malim slovima
            // ako svako ime grada počinje slovom o ispisuje super inače ispisuje ok

            // Rješenje 1

            //Console.WriteLine("Unesi tri grada: ");
            //string f = Console.ReadLine();
            //string g = Console.ReadLine();
            //string h = Console.ReadLine();

            //if(f[0] == 'o' && g[0] == 'o' && h[0] == 'o')
            //{
            //    Console.WriteLine("super");
            //}
            //else
            //{
            //    Console.WriteLine("ok");
            //}

            // Rješenje 2

            //string[] gradovi = new string[3];
            //for (int i = 0; i < gradovi.Length; i++)
            //{
            //    Console.WriteLine("Unesi ime " + (i+1) + ". grada: ");
            //    gradovi[i] = Console.ReadLine();
            //}

            //bool pocinju = true;

            //foreach(string grad in gradovi)
            //{
            //    if(grad[0] != 'o')
            //    {
            //        pocinju = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(pocinju ? "super" : "ok");

            // Rješenje 3 - DOBRA PRAKSA (Best practice)

            //string grad;

            //bool pocinje = true;

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Unesi ime " + (i +1) + ". grada: ");
            //    grad = Console.ReadLine();

            //    if (grad[0] != 'o')
            //    {
            //        pocinje = false;
            //        break;

            //    }
            //}

            //Console.WriteLine(pocinje ? "super" : " ok");


            // Kreirajte KN/EUR konverzija kalkulator

            //int vrsta;

            //while (true)
            //{
            //    Console.WriteLine("Odaberi vrstu konverzije");
            //    Console.WriteLine("1. KN -> EUR, 2. EUR -> KN");
            //    vrsta = int.Parse(Console.ReadLine());
            //    if(vrsta == 1 || vrsta == 2)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Neispravna vrsta");
            //}


            //double iznos;

            //Console.WriteLine("Unesi iznos u " + (vrsta == 1 ? "kunama" : "eurima") + ": ");
            //iznos = double.Parse(Console.ReadLine());
            //Console.WriteLine(vrsta == 1 ? iznos / 7.5345 : iznos * 7.5345);


            //if (vrsta == 1) {
            //    Console.WriteLine("Unesi iznos u kunama: ");
            //    iznos = double.Parse(Console.ReadLine());
            //    Console.WriteLine(Math.Truncate((iznos / 7.5345) * 100) / 100);  // zaokruživanje na dvije decimale

            //}
            //else
            //{
            //    Console.WriteLine("Unesi iznos u eurima: ");
            //    iznos = double.Parse(Console.ReadLine());
            //    Console.WriteLine(iznos * 7.5345);  // ovdje se ne zaokružuje
            //}


            // Napravite program koji će puknut prilikom izvođenja 
            // a biti će sintaksno ispravan

            //int i = int.Parse(Console.ReadLine()); // ako upišem slovo program puca


            // Napravite program koji u consoleu ispisuje Edunova crvenim slovima

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Edunova");
            Console.ResetColor();





        }
    }
}
