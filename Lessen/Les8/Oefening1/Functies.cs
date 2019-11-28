using System;

namespace Oefening1
{
	// Functies klasse
	public static class Functies
	{
		public static int GenereerGetal()
		{
			Random random = new Random();
			int randomNumber = random.Next(0, 100);
			return randomNumber;
		}
	}
}