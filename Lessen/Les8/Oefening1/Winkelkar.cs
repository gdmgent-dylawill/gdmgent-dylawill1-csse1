using System;

namespace Oefening1
{
	public abstract class Winkelkar
	{
		// Implementatie is afgeschermd (abstract)
		public abstract void Ontgrendelen();

		public abstract void Rijden();

		public abstract void Rijden(int snelheid);	

	}

	public class PlasticKar : Winkelkar
	{
		public PlasticKar()
		{
		}

		public override void Ontgrendelen()
		{
			
		}

		public override void Rijden()
		{

		}

		public abstract void Rijden(int snelheid)
		{

		}	

	}

	// Integreren van Winkelkar klasse (meegeven -> overerven)
	public class GroteKar : Winkelkar
	{
		public override void Ontgrendelen()
		{
			throw new NotImplementedException();
		}
				
		public override void Rijden()
		{
			throw new NotImplementedException();

		}

		public abstract void Rijden(int snelheid)
		{
			// throw new NotImplementedException();

		}	
	}
}