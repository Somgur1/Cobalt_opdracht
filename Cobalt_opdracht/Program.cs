using System;
using System.Collections.Generic;

namespace Cobalt_opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kobalt = new List<string>();
            Kobalt.Add("Arne");
            Kobalt.Add("Brenda");
            Kobalt.Add("Carly");
            Kobalt.Add("Desley");

           

            foreach (var naam in Kobalt)
            {

            }

        }

        private static void Kobalt_opdracht1()
        {
            int cijfer = 1;

            while (cijfer <= 100)
            {
                Console.WriteLine(cijfer);

                if (cijfer % 3 == 0)
                {
                    Console.WriteLine("co");
                }

                if (cijfer % 5 == 0)
                {
                    Console.WriteLine("balt");
                }

                if (cijfer % 5 == 0 && cijfer % 3 == 0)
                {
                    Console.WriteLine("cobalt");
                }
                cijfer = cijfer + 1;
            }
        }
    }
}
