using System;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Gebruiker g = new Gebruiker("dylan", "willems", 'm');
            g.LogOutput();
            Student s = new Student("Dylan", "Willems", 'M');
            s.LogOutput();
            Docent d = new Docent("Kristof", "Raes", 'M');
            d.LogOutput();
        }
    }
}
