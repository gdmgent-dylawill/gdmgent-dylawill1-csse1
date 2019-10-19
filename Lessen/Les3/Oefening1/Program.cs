using System;

namespace Les3
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            getal = 5; // Initialisatie van variabele getal met de waarde 5
            /*
                Wat gaat er verder gebeuren in onze code...
            */
            Console.WriteLine("-- DEEL 1 --");
            Console.WriteLine("Geef een getal in tussen 0 en 10");
            getal = Convert.ToInt32(Console.ReadLine());
            
            if(getal < 8)
            {
                Console.WriteLine("De waarde van het getal is: " + getal);
            }
            else if(getal > 6)
            {
                
            }

            Console.WriteLine("-- DEEL 2 --");

            // Getal afchecken met waarde bij de cases
            switch (getal)
            {
                case 7:
                    Console.WriteLine("Het getal is in dit geval (case 7): " + getal);
                    break;
                default:
                    Console.WriteLine("In alle andere gevallen: " + getal);
                    break;
            }

            int teller = 5;

            for (int i = 0; i < teller; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-- SUCCES // TEST --");
        }
    }
}
