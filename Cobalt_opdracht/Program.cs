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


                string name = kobaltmensen.Name;
                char[] charArray = name.ToCharArray();
               
                {
                    foreach (char count in name)
                    {
                        Console.WriteLine(count);

                        int a = 1;
                        int b = 2;
                        int c = 3;
                        int d = 4;
                        int e = 5;
                        int f = 5;
                        int g = 6;
                        int h = 7;
                        int i = 8;
                        int j = 9;
                        int k = 10;
                        int l = 11;
                        int m = 12;
                        int n = 13;
                        int o = 14;
                        int p = 15;
                        int q = 16;
                        int r = 17;
                        int s = 18;
                        int t = 19;
                        int u = 20;
                        int v = 21;
                        int w = 22;
                        int x = 23;
                        int y = 24;
                        int z = 25;
                    }
                }






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
     