using System;
// Import van System doen want anders kent hij bv. Console niet
// De functies zoals Console worden uit deze bibliotheek gehaald

namespace Oefening1
{
	public class Persoon1
	{
		// Velden
		public string voornaam;
		private char geslacht;

        // Properties
		public char Geslacht
		{
			get
			{ 
				return geslacht;
			}
			set
			{
				geslacht = value;
			}
		}

	/*
		get { return geslacht };
		set { geslacht = value };
	*/

		public string Naam
		{
			get;
			set;
		}

        // Constructors
		public Persoon1() // Lege instantie aanmaken
		{

		}

		public Persoon1(string naam, string voornaam) // 2 argumenten meegeven
		{

		}
		
		public Persoon1(string naam, string voornaam, char geslacht)
		{
			Naam = naam;			// Property gebruiken en invullen met variabele
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}

        // Methods
		public void LogOutput()
		{
			Console.WriteLine(String.Format("Output: Voornaam: {0}, Famillienaam: {1}, Geslacht: {2}, geslacht: {3}",this.voornaam, Naam, Geslacht, this.geslacht));
			// Eerste Geslacht is property, tweede geslacht is veld
			// Bij Geslacht wordt de get operatie uitgevoerd, de waarde wordt gereturnd
		}
	}
}