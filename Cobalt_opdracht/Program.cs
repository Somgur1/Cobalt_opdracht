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
           new KobaltNamen() { Name="arne ", Cijfer = 1},
            new KobaltNamen() { Name="brenda ", Cijfer = 2},
            new KobaltNamen() { Name="carly ", Cijfer = 3},
            new KobaltNamen() { Name="desley ", Cijfer = 4},
            new KobaltNamen() { Name="esther ", Cijfer = 5},
            new KobaltNamen() { Name="huub ", Cijfer = 6},
            new KobaltNamen() { Name="kylian ", Cijfer = 7},
            new KobaltNamen() { Name="mick ", Cijfer = 8},
            new KobaltNamen() { Name="kylian ", Cijfer = 9},
            new KobaltNamen() { Name="mick ", Cijfer = 10},
        };

            int i = 1;

            foreach (KobaltNamen kobaltmensen in Kobalt)
            {


                //string name = kobaltmensen.Name;
                //char[] charArray = name.ToCharArray();

                String abc = "arne";

                for (int i = 1; i <= abc.Length; i += 1)
                {
                    abc = abc.Insert(i, " ");
                    i++;
                }



                Console.WriteLine(abc);




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
     