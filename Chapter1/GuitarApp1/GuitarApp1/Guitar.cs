using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public enum Type
	{
		ACOUSITC,
		ELECTRIC		
	}

	public enum Builder
	{
		FENDER,
		MARTIN, 
		GIBSON, 
		COLLINGS,
		OLSON,
		RYAN, 
		PRS,
		ANY
	}

	public enum Wood
	{
		INDIAN_ROSEWOOD,
		BRAZILIAN_ROSEWOOD,
		MAHOGANY,
		MAPLE,
		COCOBOLO,
		CEDAR,
		ADIRONDACK,
		ALDER,
		SITKA
	}


	public class Guitar
	{
		public string serialNumber;
		private double price;
		private GuitarSpec spec;

		public Guitar(string serialNumber, double price,
			GuitarSpec spec)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.spec = spec;
		}

		public void print()
		{
			this.spec.print();
			Console.WriteLine("You can get it for $" + this.price + ".\n");
		}
		

		public string getSerialNumber()
		{
			return this.serialNumber;
		}

		public GuitarSpec getGuitarSpec()
		{
			return this.spec;
		}



		public void setPrice(float newPrice)
		{
			this.price = newPrice;
		}



		

		
	}
}
