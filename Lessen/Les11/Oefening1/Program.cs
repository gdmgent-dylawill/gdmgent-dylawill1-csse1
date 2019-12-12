﻿using System;
using System.Collections.Generic; // Voor list te gebruiken

namespace Oefening1
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartEconomie();
        
        void BuildPartWeer();
        
        void BuildPartReclame();
    }
    
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        private Krant _krant = new Krant();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._krant = new Krant();
        }
        
        // All production steps work with the same product instance.
        public void BuildPartEconomie()
        {
            this._krant.Add("PartEconomie1");
        }
        
        public void BuildPartWeer()
        {
            this._krant.Add("PartWeer1");
        }
        
        public void BuildPartReclame()
        {
            this._krant.Add("PartReclame1");
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
            Krant result = this._krant;

            this.Reset();

            return result;
        }
    }
    
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
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        // Enkel sectie Economie tonen
        public void buildMinimalViableKrant()
        {
            this._builder.BuildPartEconomie();
        }
        
        // Alle secties tonen
        public void buildFullFeaturedKrant()
        {
            this._builder.BuildPartEconomie();
            this._builder.BuildPartWeer();
            this._builder.BuildPartReclame();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            
            // Enkel sectie Economie tonen
            Console.WriteLine("Standard basic krant:");
            director.buildMinimalViableKrant();
            Console.WriteLine(builder.GetKrant().ListParts());

            // Alle secties tonen
            Console.WriteLine("Standard full featured krant:");
            director.buildFullFeaturedKrant();
            Console.WriteLine(builder.GetKrant().ListParts());

            // Custom krant
            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom krant:");
            builder.BuildPartEconomie();
            builder.BuildPartReclame();
            Console.Write(builder.GetKrant().ListParts());
        }
    }
}
