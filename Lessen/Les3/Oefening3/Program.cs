using System;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
        // DEEL A (while loop) - zelfde als oef 2 maar met WHILE loop
            Console.WriteLine("-- Oef 3: DEEL A --");
            
            // Declaratie variabelen
            int i = 0;
            int tafel = 5;

            // WHILE loop
            while (i <= 10)
            {
               Console.WriteLine("" + i + " x " + tafel + " = " + i*tafel);
               i++;
            }

        // DEEL B (do while loop) - zelfde als oef 2 maar met DO WHILE loop
            // Wordt dus minstens 1 keer uitgevoerd
            Console.WriteLine("-- Oef 3: DEEL B --");
            
            // Declaratie variabele
            int j = 0;

            // DO WHILE loop
            do
            {
                Console.WriteLine("" + j + " x " + tafel + " = " + j*tafel);
                j++; 
            } while (j <= 10);

        }
    }
}
