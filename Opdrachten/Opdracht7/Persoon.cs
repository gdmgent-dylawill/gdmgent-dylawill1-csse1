using System;

namespace Opdracht7
{
	public class Persoon : Logging{
		// Velden
		public string voornaam;
		private char geslacht;

        // Properties
		public char Geslacht{
			get
			{
				return geslacht;
			}
			set
			{
				geslacht = value;
			}
		}

		public string Naam{
			get;
			set;
		}

        // Constructor
		public Persoon(){

		}
		
		public Persoon(string vnaam, string anaam){
			
		}

		public Persoon(string vnaam, string anaam, char geslacht){
			Naam = anaam;
			this.voornaam = vnaam;
			Geslacht = geslacht;
		}

		
        // Methods
		public virtual void LogOutput(){
			Console.WriteLine(String.Format("Output: Voornaam: {0}, Achternaam: {1}, Geslacht: {2}", this.voornaam, Naam, Geslacht));
		}
	}
}