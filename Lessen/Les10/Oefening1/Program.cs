using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
// Zodat je aan klasse Clients kan (-> Client.cs)
using Clients;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a client with a contact person.
            // Creation of a Client object with the name c1.
            Client c1 = new Client();
            c1.Name = "Arteveldehogeschool vzw";
            // Creation of a ContactPerson object with the name cp1.
            ContactPerson cp1 = new ContactPerson();
            cp1.Name = "Muqid";
            cp1.FamilyName = "Raes";
            cp1.DateOfBirth = new DateTime(1986, 4, 9);
            cp1.PrivateAddress = new Address(AddressType.Private, "Hemelstraat", "201", "bus 20", "9000", "Gent");
            // c1.ContactPerson = cp1;
            
            // Nu met lijst met contactpersonen
            // Aanmaken list best voor assignment property
            // cpen = contactpersoon
            SortedList lijstAdressen = new SortedList();
            Address ad1 = new Address();
            ad1.Street = "Hoogstraat";
            Address ad2 = new Address();
            ad2.Street = "Laagstraat";
            lijstAdressen.Add(1, ad1); // key/value
            lijstAdressen.Add(2, ad2); // key/value
            List<ContactPersons> cpen = new List<ContactPerson>();
            cpen.Add(cp1);
            // DateTime dt = new DateTime(1986, 3, 2);
            cpen.Add(new ContactPerson("Kristof", "Raes", a1, new DateTime(1986, 3, 2)));
            c1.contactPersons = cpen;
            
            c1.Vat = "BE0474.120.360";
            // c1.CompanyAddress = new Address(AddressType.Company, "Hoogpoort", "15", "", "9000", "Gent");
            c1.Type = ClientType.Company;

            Console.WriteLine("Contactpersonen: ");
            foreach (var item in cpen)
            {
                Console.WriteLine(item.Name);
            }



            // 1) Arrays
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // 1.1) 1 dimensionale array
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // Array met bedragen (double datatype), grootte van de array is 10.
            double[] bedragen = new double[10];
            // Array met getallen (int datatype), grootte van de array is 5.
            int[] getallen = new int[5] { 1, 2, 3, 4, 5 };
            // Opvragen van het 2de getal van de array getallen.
            Console.WriteLine("Het 2de getal van de array getallen: {0}", getallen[1]);
            // Waarde opgeven voor de 1ste en 2de plek in de array bedragen.
            bedragen[0] = 2.50;
            bedragen[1] = 4.12;
            // Uitlezen van het 2de getal van de array bedragen.
            Console.WriteLine("Het 2de getal van de array bedragen: {0}", bedragen[1]);
            Address a2 = new Address(AddressType.Private, "Hemelstraat", "201", "bus 20", "9000", "Gent");
            Address a3 = new Address(AddressType.Private, "Industrieweg", "232", "", "9030", "Mariakerke");
            Address[] adressen = new Address[2] {a2, a3};
            Console.WriteLine("Het 2de adres van de array van adressen is: {0}", adressen[1]);

            // 1.2) Multidimensionale arrays
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // 2 dimensionale array
            string[,] wagens = new string[3, 2] { { "BMW", "520" }, { "Golf", "1,9 TDI" }, { "Mercedes-Benz", "E 200" } };
            // Afdrukken type van de Golf.
            Console.WriteLine(wagens[1, 1]);
            // 3 dimensionale array
            int[, ,] cijfers = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            // 1.3) BitArray
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            bool[] booleans = new bool[5] { true, false, true, true, false };
            BitArray ba = new BitArray( booleans );
            Console.WriteLine("Aantal: {0}", ba.Count);
            Console.WriteLine("Lengte: {0}", ba.Length);

            // 2) Collecties
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // 2.1) ArrayList
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // Aanmaak arraylist met toevoeging van 3 elementen.
            ArrayList al = new ArrayList();
            
            al.Add("C");
            al.Add("BBBHello");
            al.Add("BBBBBB");
            al.Add("AAAWorld");
            al.Add("!");
            // Opvragen van het 2de element.
            Console.WriteLine("2de waarde:  {0}", al[1]);
            // Het aantal, de capaciteit en de elementen opvragen.
            Console.WriteLine("Aantal: {0}", al.Count );
            Console.WriteLine("Capaciteit: {0}", al.Capacity );

            al.Sort();
            Console.WriteLine("2de waarde na sortering:  {0}", al[1]);
            // 1ste waarde = !
            Console.WriteLine("1ste waarde na sortering:  {0}", al[0]);

            // 2.2) List
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            // Aanmaak van een lijst met strings.
            List<string> namen = new List<string>();
            // Toevoegen van namen tot de lijst.
            namen.Add("Bart");
            namen.Add("Geert");
            namen.Add("Kristof");
            Console.WriteLine();
            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }
            Console.WriteLine("");
            Console.WriteLine("Capaciteit: {0}", namen.Capacity);
            Console.WriteLine("Aantal: {0}", namen.Count);
            // Een elment verwijderen.
            namen.Remove("Bart");
            // Ledigen van lijst.
            namen.Clear();

            // 2.3) SortedList
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            SortedList sl = new SortedList();
            sl.Add("B", "World");
            sl.Add("C", "!");
            sl.Add("A", "Hello");
            Console.WriteLine("Count:    {0}", sl.Count );
            Console.WriteLine("Capacity: {0}", sl.Capacity );
            Console.WriteLine("Key van 2de element: {0}", sl.GetKey(1));
            Console.WriteLine("Value van 2de element: {0}", sl.GetByIndex(1));
            Console.WriteLine("Value van het element met key C: {0}", sl["C"]);

            // 2.4) Hashtable
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            Hashtable openenMet = new Hashtable();
            openenMet.Add("rtf", "wordpad.exe");
            openenMet.Add("jpg", "paint.exe");
            openenMet.Add("txt", "notepad.exe");
            openenMet.Add("pdf", "AcroRd32.exe");
            openenMet["jpg"] = "Illustrator.exe";
            Console.WriteLine("Opvragen waarde voor key jpg, waarde: {0}", openenMet["jpg"]);
            openenMet.Remove("pdf");

            // 2.5) Queue
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            Queue q = new Queue();
            q.Enqueue("Hello");
            q.Enqueue("World");
            q.Enqueue("!");
            Console.WriteLine("Aantal: {0}", q.Count);
            Console.WriteLine("Een element uitlezen: " + q.Dequeue());
            q.Enqueue("!");

            // 2.6) Stack
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            Stack st = new Stack();
            st.Push("Hello");
            st.Push("World");
            st.Push("!");
            Console.WriteLine("Aantal: {0}", st.Count );
            Console.WriteLine( "Weergeven element, (Pop): {0}", st.Pop() );
            Console.WriteLine( "Weergeven element, (Peek): {0}", st.Peek() );

            // 2.7) Dictionary
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            Dictionary<string, string> openenMet2 = new Dictionary<string, string>();
            openenMet2.Add("rtf", "wordpad.exe");
            openenMet2.Add("jpg", "paint.exe");
            openenMet2.Add("txt", "notepad.exe");
            openenMet2.Add("pdf", "AcroRd32.exe");
            openenMet2["jpg"] = "Illustrator.exe";
            Console.WriteLine("Opvragen waarde voor key jpg, waarde: {0}", openenMet2["jpg"]);

            // 2.8) HashSet
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(3);
            hs.Add(5);
            hs.Add(7);
            Console.WriteLine("Aantal: {0}", hs.Count);
            Console.Write("Elementen: ");
            Console.Write("{");
            foreach (int i in hs)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");

            // 2.9) ConcurrentBag
            // -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            cb.Add(1);
            cb.Add(3);
            cb.Add(5);
            cb.Add(7);
            int element;
            while (!cb.IsEmpty)
            {
                if (cb.TryTake(out element))
                    Console.WriteLine(element);
            }


        }
    }
}
