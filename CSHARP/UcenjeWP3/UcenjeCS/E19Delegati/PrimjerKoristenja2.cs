using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E19Delegati
{
    internal class PrimjerKoristenja2
    {

        public PrimjerKoristenja2()
        {
            var os = new ObradaSmjer();
            os.IspisSmjer(NijeBitno);

            // dobra praksa
            os.IspisSmjerAction(s =>
            {
                Console.WriteLine("3 " + s.Naziv);
            });
        }

        private void NijeBitno(Smjer s)
        {
            Console.WriteLine("2 " + s.Naziv);
        }

    }
}
