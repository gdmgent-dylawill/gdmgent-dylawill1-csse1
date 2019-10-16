using System;

namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Oef 5: Fibonacci --");

            // Declaratie van de variabelen
            int Length, Counter, Fibo1, Fibo2, Fibo3;
            Fibo1 = 0;
            Fibo2 = 1;

            // Lengte reeks opvragen
            Console.WriteLine("Geef het aantal elementen in:");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De lengte van de reeks is: " + Length);
            Length = Length - 3;


            // De reeks laten starten met de eerste 2 getallen van Fibonacci (0 en 1)
            Console.WriteLine(Fibo1);
            Console.WriteLine(Fibo2);

            // Weergeven van de reeks van Fibonacci (met ingegeven aantal elementen)
            for(Counter = 0; Counter <= Length; Counter++) {
                Fibo3 = Fibo1 + Fibo2;
                Fibo1 = Fibo2;
                Fibo2 = Fibo3;

                // Weergave in de console
                Console.WriteLine(Fibo3);
            }
        }
    }
};
