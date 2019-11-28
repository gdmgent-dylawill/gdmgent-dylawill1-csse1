using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon();      // p = persoon

            Persoon1 p1 = new Persoon1();
            p1.voornaam = "Dylan";
            p1.Geslacht = 'M'; // Enkele aanhalingstekens want het is een char
            p1.Naam = "Willems";
            p1.LogOutput();

            Persoon1 p2 = new Persoon1("Kristof", "Raes", 'M');
            p2.LogOutput();

            Gebruiker g = new Gebruiker();  // g = gebruiker

            Gebruiker g1= new Gebruiker("Dylan", "Willems", 'M');
            Gebruiker g2 = new Gebruiker("Evelien", "Rutsaert", 'V');

            g1.LogOutput();
        
        }
    }

    public class Persoon
    {
        // Velden

        // Properties

        // Constructors

        // Methods
        public void LogOutPut()
        {
            Console.WriteLine();
        }
    }
}
