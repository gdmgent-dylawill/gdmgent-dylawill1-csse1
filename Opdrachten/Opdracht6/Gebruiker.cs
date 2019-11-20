using System;
using System.Security.Cryptography;
using System.Text;

namespace Opdracht6 {
	public class Gebruiker : Persoon {
		// Velden
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

		// Properties
		public string Gebruikersnaam {
			get
			{
				return this.gebruikersnaam;
			}
		}
		public string Wachtwoord {
			get
			{
				return this.wachtwoord;
			}
		}
		public string Login {
			get
			{
				return this.login;
			}
		}

		// Constructors
		public Gebruiker() {
			GenereerWachtwoord();
		}

		public Gebruiker(string vnaam, string anaam, char geslacht) : base (vnaam, anaam, geslacht){
			this.gebruikersnaam = GenereerGebruikersnaam(vnaam, anaam);
			this.login = GenereerEmail(this.gebruikersnaam);
			GenereerWachtwoord();
		}

		public Gebruiker(string vnaam, string anaam, char geslacht, string gebruikersnaam, string ww, string login) : base (vnaam, anaam, geslacht){
			this.gebruikersnaam = gebruikersnaam;
			this.wachtwoord = ww;
			this.login = login;
		}
		
		// Methods
		public override void LogOutput() {
			Console.WriteLine(String.Format("Output: Voornaam: {0}, Achternaam: {1}, Geslacht: {2}, Gebruikersnaam: {3}, Login: {4}", this.voornaam, Naam, Geslacht, Gebruikersnaam, Login));
		}
		public virtual void GenereerWachtwoord() {
			string ww = "secret";
			Console.WriteLine(String.Format("Je wachtwoord is : {0}", ww));
			this.wachtwoord = GetHashString(ww);
		}
		
		protected string GetStartOfString(string input, int lengte) {
			return input.Substring(0, lengte);
		}

		private string GenereerEmail(string gebruikersnaam) {
			string loginNaam = gebruikersnaam + "@gebruiker.be";
			return loginNaam;
		}

		private string GenereerGebruikersnaam(string vnaam, string anaam) {
			string gebruikersnaam = "";
			string kvnaam = GetStartOfString(vnaam, 4);
			string kanaam = GetStartOfString(anaam, 4);
			gebruikersnaam = kvnaam.ToLower() + kanaam.ToLower();
			
			return gebruikersnaam;
		}

		// Hash
		public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

		// Hash
		public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

	}

}