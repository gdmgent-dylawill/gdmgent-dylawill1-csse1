using System;
using System.Collections.Generic; // Om list te gebruiken

namespace Opdracht8
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.

    // The parts of the Krant
    public interface IBuilder
    {
        void BuildEconomie();
        
        void BuildWeer();
        
        void BuildReclame();

        void BuildTVGids();
    }
    
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    
    // --- Krant 1: HLN --- //
    // The ConcreteBuilder is the Krant (the name)
    public class HLNBuilder : IBuilder
    {
        private Krant _HLN = new Krant();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public HLNBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._HLN = new Krant();
        }
        
        // All production steps work with the same product instance.

        // The parts of the section
        public void BuildEconomie()
        {
            this._HLN.Add("ECONOMIE");
            this._HLN.Add("Titel");
            this._HLN.Add("Artikel");
            this._HLN.Add("Auteur");
        }
        
        public void BuildWeer()
        {
            this._HLN.Add("WEER");
            this._HLN.Add("Foto");
            this._HLN.Add("Tekst");
        }
        
        public void BuildReclame()
        {
            this._HLN.Add("RECLAME");
            this._HLN.Add("Foto");
            this._HLN.Add("Tekst");        }

        public void BuildTVGids()
        {
            this._HLN.Add("TVGIDS");
            this._HLN.Add("Artikel");
            this._HLN.Add("Zender");
            this._HLN.Add("Tijdstippen");
        }
        
        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Krant GetKrant()
        {
            // Result
            Krant HLN = this._HLN;

            this.Reset();

            return HLN;
        }
    }

    // --- End of Krant 1: HLN --- //



    // --- Krant 2: De Tijd --- //
    // The ConcreteBuilder is the Krant (the name)
    public class DeTijdBuilder : IBuilder
    {
        private Krant _DeTijd = new Krant();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public DeTijdBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._DeTijd = new Krant();
        }
        
        // All production steps work with the same product instance.

        // The parts of the section
        public void BuildEconomie()
        {
            this._DeTijd.Add("ECONOMIE");
            this._DeTijd.Add("Titel");
            this._DeTijd.Add("Artikel");
            this._DeTijd.Add("Auteur");
        }
        
        public void BuildWeer()
        {
            this._DeTijd.Add("WEER");
            this._DeTijd.Add("Foto");
            this._DeTijd.Add("Tekst");
        }
        
        public void BuildReclame()
        {
            this._DeTijd.Add("RECLAME");
            this._DeTijd.Add("Foto");
            this._DeTijd.Add("Tekst");        }

        public void BuildTVGids()
        {
            this._DeTijd.Add("TVGIDS");
            this._DeTijd.Add("Artikel");
            this._DeTijd.Add("Zender");
            this._DeTijd.Add("Tijdstippen");
        }
        
        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Krant GetKrant()
        {
            // Result
            Krant DeTijd = this._DeTijd;

            this.Reset();

            return DeTijd;
        }
    }

    // --- End of Krant 2: De Tijd --- //
    
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Krant
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Krant parts: " + str + "\n";
        }
    }
    
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.

    // Director => Variations
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.

        // Show only section Economie
        public void buildMinimalViableKrant()
        {
            this._builder.BuildEconomie();
        }
        
        // Show all sections
        public void buildFullFeaturedKrant()
        {
            this._builder.BuildEconomie();
            this._builder.BuildWeer();
            this._builder.BuildReclame();
            this._builder.BuildTVGids();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            
            // HLN //

            Console.WriteLine("-- Krant 1: HLN ---");
            
            var director = new Director();
            var builder = new HLNBuilder();
            director.Builder = builder;
            
            // Show only section Economie
            Console.WriteLine("Standard basic krant:");
            director.buildMinimalViableKrant();
            Console.WriteLine(builder.GetKrant().ListParts());

            // Show all sections
            Console.WriteLine("Standard full featured krant:");
            director.buildFullFeaturedKrant();
            Console.WriteLine(builder.GetKrant().ListParts());

            // Custom krant
            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom krant:");
            builder.BuildEconomie();
            builder.BuildTVGids();
            Console.Write(builder.GetKrant().ListParts());



            // De Tijd //

            Console.WriteLine("-- Krant 2: De Tijd ---");
            
            var director2 = new Director();
            var builder2 = new DeTijdBuilder();
            director2.Builder = builder2;
            
            // Show only section Economie
            Console.WriteLine("Standard basic krant:");
            director2.buildMinimalViableKrant();
            Console.WriteLine(builder2.GetKrant().ListParts());

            // Show all sections
            Console.WriteLine("Standard full featured krant:");
            director2.buildFullFeaturedKrant();
            Console.WriteLine(builder2.GetKrant().ListParts());

            // Custom krant
            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom krant:");
            builder2.BuildEconomie();
            builder2.BuildReclame();
            Console.Write(builder2.GetKrant().ListParts());
        }
    }
}