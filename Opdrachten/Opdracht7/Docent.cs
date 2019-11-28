using System;

namespace Opdracht7
{
	class Docent : Gebruiker
	{
		public Docent(){
		}

		public Docent(string vnaam, string anaam, char geslacht) : base(vnaam, anaam, geslacht) {
			this.gebruikersnaam = GenereerGebruikersnaam(vnaam, anaam);
			this.login = GenereerEmail(this.gebruikersnaam);
		}

		private string GenereerEmail(string gebruikersnaam) {
			string loginNaam = gebruikersnaam + "@arteveldehs.be";
			return loginNaam;
		}
		private string GenereerGebruikersnaam(string vnaam, string anaam) {
			string gebruikersnaam = "";
			string kvnaam = GetStartOfString(vnaam, 4);		// Korte versie
			string kanaam = GetStartOfString(anaam, 2);		// Korte versie
			gebruikersnaam = kvnaam.ToLower() + kanaam.ToLower();
			
			return gebruikersnaam;
		}

		public override void GenereerWachtwoord() {
			string ww = "secretDocent";
			Console.WriteLine(String.Format("Je wachtwoord is : {0}", ww));
			this.wachtwoord = GetHashString(ww);
		}
	}
}