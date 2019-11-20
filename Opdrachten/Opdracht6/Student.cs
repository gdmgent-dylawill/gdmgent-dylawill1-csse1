using System;

namespace Opdracht6
{
	class Student : Gebruiker
	{
		public Student(){
		}

		public Student(string vnaam, string anaam, char geslacht) : base(vnaam, anaam, geslacht) {
			this.login = GenereerEmail(this.gebruikersnaam);
		}

		private string GenereerEmail(string gebruikersnaam) {
			string loginNaam = gebruikersnaam + "@student.arteveldehs.be";
			return loginNaam;
		}
		public override void GenereerWachtwoord(){
			string ww = "secretStudent";
			Console.WriteLine(String.Format("Je wachtwoord is : {0}", ww));
			this.wachtwoord = GetHashString(ww);
		}
	}
}