using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnoGrananjeIf : ControllerBase
    {


        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            // Ruta prima dva cijela broja.
            // Ako je zbroj primljenih brojeva paran broj 
            // vraća njihov umnožak, inače vraća njihov zbroj

            //return (a+b)%2==0 ? a*b : a+b;

            int zbroj = a + b;

            if(zbroj%2 == 0)
            {
                return a * b;
            }
            else
            {
                return a + b;  // zbroj
            }
            
            

        }
        // Ovdje završava ruta





        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public string Zad2(int ocjena)
        {
            // Ruta prima brojčanu ocjenu.
            // Ruta vraća slovnu ocjenu

           

            switch (ocjena)
            {
                case 1:
                    return "nedovoljan";
                   
                case 2:
                    return "dovoljan";
                    
                case 3:
                    return "dobar";
                
                case 4:
                    return "vrlo dobar";
                    
                case 5:
                    return "odličan";
                   
                default:
                    return "Nije ocjena";
                    
            }



        }
        // Ovdje završava ruta

    }
}
