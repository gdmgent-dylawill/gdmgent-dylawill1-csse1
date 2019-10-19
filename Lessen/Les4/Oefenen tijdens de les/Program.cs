using System;

namespace Les4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- LES 4 --");

            // int fahr = 100;
            // int cels = (fahr - 32) * (5/9);

            // Console.WriteLine(cels);
            
            // int veranderen naar double
            double fahr = 100;
            double cels = (fahr - 32) * (5.0/9.0);

            Console.WriteLine(cels);

            Boolean testBool;
            // testBool = true;
            Console.WriteLine(testBool.ToString());

            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine(sizeof(System.Boolean).ToString()); // 1 Byte
            Console.WriteLine(sizeof(System.Int32).ToString()); // 4 Byte, zelfde grootte als integer
            Console.WriteLine(sizeof(System.Int64).ToString()); // 8 Byte, integer van het formaat 64 bit
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(new System.Boolean()));
            
            // De waarde van de variabele a wijzigen naar de letter b
            char a = 'c';
            a = 'b';

            string mijnString = "Dit is mijn eerste regel tekst ...";
            Console.WriteLine(mijnString);
            string mijnString2 = "Dit is mijn gesplitste\n tekst ...";
            Console.WriteLine(mijnString2);

            // Met write komt er gewoon iets bij op de plaats waar je zit
            // Met WriteLine schrijf je iets op een nieuwe lijn

            // Declareer en initialiseer een string
            string mijnString3 = "Hello";
            string mijnString4 = "World";

            // Samenvoegen van de string met een spatie tussen (concatenatie)
            string mijnString5 = mijnString3 + " " + mijnString4;
            Console.WriteLine(mijnString5); // Resultaat weergeven

            const double Interest = 0.80;

            // Voorbeelden met decimal waarden
            int x = 14;
            int y = 8;
            int result1 = x + y; // result1 = 22
            int result2 = x - y; // result2 = 
            int result3 = x * y; // result3 =
            int result4 = x / y; // result4 =
            int result5 = x % y; // result5 =
            int result6 = x + y; // result6 =
            int result7 = --y; // result7 = 7
            int result8 = ++x; // result8 = 15, x = 15

            // Voorbeelden met decimal waarden
            decimal a = 8.5m;
            decimal b = 3.4m;
            decimal result1 = a + b; // result1 = 11.9
            Console.WriteLine("a + b: " + result1);
            decimal result2;

            // Voorbeelden met char waarden
            char letter1 = 'C';
            // letter1 = 'C';
            // Unicode integer is 67
            char letter2 = ++letter1;

            Console.WriteLine("letter1: " + letter2.ToString());
            // letter2 = 'D'
            // Unicode integer is 68

        }
    }
}
