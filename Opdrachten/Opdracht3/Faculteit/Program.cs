using System;

namespace Oefening4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-- Oef 4: Faculteit --");

            // Declaratie van de variabelen
            // Faculteit van 0 = 1
            int Counter, Number, Faculteit;
            Faculteit = 1;

            // Opvragen van een willekeurig getal
            Console.WriteLine("Geef een willekeurig getal in");
            Number = Convert.ToInt32(Console.ReadLine());

            // Berekening van de faculteit van ingegeven getal
            for (Counter = 1; Counter <= Number; Counter++) {
                Faculteit = Faculteit * Counter;
            }

            // Weergave in de console
            Console.WriteLine("De faculteit van " + Number + " is " + Faculteit);
        }
    }
};