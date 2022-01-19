using System;
using System.Collections.Generic;

namespace Cobalt_opdracht
{
    class Program
    {
        public class KobaltNamen
        {
            public string Name { get; set; }
            public int Cijfer { get; set; }
        }



        static void Main(string[] args)
        {

            var Kobalt = new List<KobaltNamen>//in word op afphabetische folgorde gezet
        {
           new KobaltNamen() { Name="Arne ", Cijfer = 1},
            new KobaltNamen() { Name="Brenda ", Cijfer = 2},
            new KobaltNamen() { Name="Carly ", Cijfer = 3},
            new KobaltNamen() { Name="Desley ", Cijfer = 4},
            new KobaltNamen() { Name="Esther ", Cijfer = 5},
            new KobaltNamen() { Name="Huub ", Cijfer = 6},
            new KobaltNamen() { Name="Kylian ", Cijfer = 7},
            new KobaltNamen() { Name="Mick ", Cijfer = 8},
            new KobaltNamen() { Name="Kylian ", Cijfer = 9},
            new KobaltNamen() { Name="Mick ", Cijfer = 10},
        };

            foreach (KobaltNamen kobaltmensen in Kobalt)
            {



                int Count = 0;
                foreach (char c in kobaltmensen.Name)
                {
                    if (c != ' ')
                    {
                        Count++;
                    }
                }
                int k = Count;

                Console.WriteLine(kobaltmensen.Name + k);

            }
        }
    }
}

                
                
            

        

    /*
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
    */
     