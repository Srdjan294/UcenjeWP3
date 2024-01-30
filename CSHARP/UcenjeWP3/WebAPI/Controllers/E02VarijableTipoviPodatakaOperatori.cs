using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori:ControllerBase
    {


        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            // Ruta vraća najveći int broj
            
            return int.MaxValue;

        }
        // Ovdje završava ruta







        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public float Zad2(int a, int b)
        {
            // Ruta vraća kvocijent dvaju primljenih brojeva

            return a/(float)b;

        }
        // Ovdje završava ruta



        // Ruta prima dva cijela broja i vraća zbroj umnoška i kvocijenta primljenih brojeva

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad3")]
        public float Zad3(int x, int y)
        {
            
            return (x*y) + (x/(float)y);

        }
        // Ovdje završava ruta


        // Ruta prima dva cijela broja, vraća true ako je a = b, inače vraća false

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad4")]
        public bool Zad4(int d, int e)
        {

            return d == e;

        }
        // Ovdje završava ruta



        // Ruta prima dva stringa i vraća ih sljepljenje s razmakom nazad

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad5")]
        public string Zad5(string j, string k)
        {

            return j + " " + k;

        }
        // Ovdje završava ruta
    }
}
