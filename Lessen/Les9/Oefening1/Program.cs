using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        /// <summary>
        /// Method DoeIets gaat een lijn afdrukken in de console
        /// </summary>
        static void DoeIets()
        {
            // TODO: Implementatie nog verder uitbreiden
            Console.WriteLine("Gedaan!");
            // NOTE: Een lijn wegschrijven
        }

        
        static void DoeIets2()
        {
            Console.WriteLine("Gedaan!");
        }

        public interface IAantal
        {
            public abstract void LogAantal();
            
            // Interfaces zijn niet bedoeld voor velden, je kan geen velden gebruikt
            // public string aantal;
        }

        public interface ILogging
        {
            // private void LogOutput(string input);

            /*
            Als je het weglaat is het ook public
            void LogOutput(string input);
            */

            // Enkel public members
            // public staat wit want hij verwacht dat het sowieso public is
            public void LogOutput(string input);
        }

        public interface Interfaces{
            // public staat wit want hij verwacht dat het sowieso public is
            public void DoeNogIets(string input);
        }

        public abstract class B : ILogging, IAantal, IC      // multiple inheritance
        {
            private string prefix;
            // klassenaam String (komt op hetzelfde neer)
            public String Suffix
            {
                get;
                set;
            }
            // keyword abstract meegeven
            public abstract void GeefAantal();
            public void DoeIets() // toegangkelijkheid - type void - geen parameters
            {
                Console.WriteLine("We gaan er hier iets mee doe");
            }

            // Implementatie abstract member
            // public abstract void LogOutput(string input);

            /*
            public void LogOutput(string input)
            {
                
            }
            */

            public void LogOutput(string input)
            {
                //
            }
        }

        // A erft over van B, en implementeert 3 interfaces
        public class A : B, ILogging, IC, IAantal
        {
            public string Aantal
            {
                get;
                set;
            }
            public A()
            {}

            public void LogOutput(string input)
            {
                Console.WriteLine("LogOutput: " + input);
                // throw new NotImplementedException();
            }

            public override void GeefAantal()
            {
                Console.WriteLine(this.Aantal);
                // throw new NotImplementedException();
            }

            // Expliciet: verwijzing naar interface
            void ILogging.LogOutput(string input);
        }
    }
}
