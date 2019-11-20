using System;
using System.Threading;

namespace Les5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SchrijfLog(args.Length);
                SchrijfLog(args[0]);
            }
            catch (System.IndexOutOfRangeException)
            {
                SchrijfLog("De collectie is ledig ...");
            }
            catch (System.Exception)
            {
                SchrijfLog("Er is een probleem ...");
            }

            
            // SchrijfLog(args.Length);
            // SchrijfLog(args[0]);
            
            // Console.WriteLine(Product(5,2));
            // SchrijfLog(Convert.ToString(Product(2,3))); // Omzetten naar string want SchrijfLog verwacht een string
            // SchrijfLog(Product(2,3)).ToString();         // Omzetten naar string (korter)
            //    SchrijfLog(Product(2,3));
            //    SchrijfLog(Verhogen(2));
            // Verhogen(2);

            SchrijfLog(GenereerWillekeurigGetal());         // Selecteer random getal zonder begrenzing
            SchrijfLog(GenereerWillekeurigGetal(1,45));     // Selecteer getal tussen 1 en 45

            SchrijfLog(GenereerLottoGetallen());

            LottoTrekking();
        

        // Genereer de getallen voor Euro Millions
        // Hierbij dien je 5 getallen (1 - 50) te selecteren en 2 sterren (1 - 12)

/*
        // Account generator
        Docenten: 4 letter van de voornaam en
        2 letters van de famillienaam, voorbeeld: krisra

        Studenten: 4 letters van de voornaam en
        4 letters van de famillienaam, voorbeeld: krisraes
*/
        Console.WriteLine("Registratie van een student...");
        SchrijfLog("Geef de voornaam in van de student");
        string voornaam = Console.ReadLine();
        SchrijfLog("Geef de naam in van de student");
        string naam = Console.ReadLine();
        Console.WriteLine("Aanmaak van het account van een student...");
        SchrijfLog(GenereerAccount(voornaam, naam));
    }

        static string GenereerAccount(string voonaam, string famillienaam)
        {
                return string.Format("Het account van {0} {1} is: {2}", // Format is string samenstellen (a.d.h.v. template); op de plaats van {0}, {1} en {2} verwacht je een waarde
                voornaam, famillienaam,
                GenereerString(voornaam, 4) +
                GenereerString(famillienaam.ToLower(), 4));     // De 2 GenereerStrings samen komen op plaats {2}
        }

        static string GenereerString(string input, int lengte)
        {
            return input.Substring(0, lengte);                  // Substring is stuk van de string teruggeven (gaat deel van een string teruggeven), 0 is het startpunt
        }

        static int Som(int getal1, int getal2)
        {
            SchrijfLog("Som...");
            return getal1 + getal2;
        }

         static int Verschil(int getal1, int getal2)
        {
            SchrijfLog("Verschil...");
            return getal1 - getal2;
        }

        static int Product(int getal1, int getal2)
        {
            SchrijfLog("Product...");
            return getal1 * getal2;
        }

        static int Quotient(int getal1, int getal2)
        {
            SchrijfLog("Quotient...");
            return getal1 / getal2;
        }
/*
        static int Verhogen(int getal)
        {
            SchrijfLog("Verhogen...");
            int getal2 = getal++;
            SchrijfLog("Verhogen: " + getal2);
            return getal2;
        }
*/

        static int Verhogen(int getal)
        {
            SchrijfLog("Verhogen...");
            int getal2 = ++getal;               // ++ voor getal! Vermeerderen met 1 en vervolgens gebruiken in expressie
            SchrijfLog("Verhogen: " + getal2);
            return getal2;
        }
    
        static int Verlagen(int getal)
        {
             SchrijfLog("Verlagen...");
            return --getal;
        }

        // static void SchrijfLog(string output) => Console.WriteLine(output);

        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());

        static void GenereerWillekeurigGetal()
        {
            Random r = new Random();
            return (r.Next());
        }

        static int GenereerWillekeurigGetal(int min, int max)
        {
            Random r = new Random();
            return (r.Next(min,max));
        }

        static string GenereerLottoGetallen()
        {
            string output = "";
            for (int i = 0; i < 6; i++)
            {
                output += " " + GenereerWillekeurigGetal(1,45);
            }
            return output;
        }

        static void LottoTrekking()
        {
            SchrijfLog("Lottotrekking");
            for (int i = 0; i < 6; i++)
            {
                SchrijfLog(GenereerWillekeurigGetal(1,45));         // Getal direct wegschrijven in console
                Thread.Sleep(5000);                                 // 5 seconden wachten na elk getal
            }
        }

    }
}
