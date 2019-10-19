using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEEL A -> Tafel van 5 (for loop)
            Console.WriteLine("-- Oef 2: DEEL A --");
            int tafel = 5;
            // int i = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("" + i + " x " + tafel + " = " + i*tafel);
            }
            
            // DEEL B -> Alle tafels van 1 tot 10
            Console.WriteLine("-- Oef 2: DEEL B --");
            // int tweedeTafel = 5;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("" + i + " x " + j + " = " + i * j);
                }
                
            }

            // DEEL C -> Tafel van een zelfingegeven getal
            Console.WriteLine("-- Oef 2: DEEL C --");
            Console.WriteLine("Geef een getal in waarvan je de vermenigvuldigingstafel wil");
            int specifiekeTafel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("" + i + " x " + specifiekeTafel + " = " + i*specifiekeTafel);
            }
        }
    }
}
