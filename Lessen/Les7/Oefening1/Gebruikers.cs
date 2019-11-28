namespace Oefening1
{
	public class Gebruiker : Persoon1
	// Overerven van de klasse van Persoon1 met de dubbelpunt
	{
		// Velden
		private string gebruikersnaam;
		private string wachtwoord;
		private string login;

        // Properties
		public string Gebruikersnaam
		{
			get
			{
				return this.gebruikersnaam;
			}
		}

        // Constructors
		public Gebruiker(string voornaam, string familienaam, char geslacht)
		// Als je niet de default constructor wilt kan je altijd gegevens opvragen (parameters meegeven)
		{
			this.LogOutput();
		}

        // Methods
		public void GenereerAccount()
		{

		}
		public void GenereerWachtwoord()
		{

		}

	}
}