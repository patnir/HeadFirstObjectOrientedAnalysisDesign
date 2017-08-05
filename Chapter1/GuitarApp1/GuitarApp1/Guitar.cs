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
		private Builder builder;
		private string model;
		private Type type;
		private Wood backWood;
		private Wood topWood;
		private double price;

		public Guitar(string serialNumber, double price,
			Builder builder, string model, Type type, Wood backWood,
			Wood topWood)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.topWood = topWood;
			this.backWood = backWood;
		}

		public void print()
		{
			Console.WriteLine(
				this.builder + " " + this.model + " " + this.type + " guitar:\n"
				+ this.backWood + " back and sides, and " + this.topWood + " top.\nYou can get it for $" + this.price
				 + "\n");
		}

		public string getSerialNumber()
		{
			return this.serialNumber;
		}

		public Builder getBuilder()
		{
			return this.builder;
		}

		public void setPrice(float newPrice)
		{
			this.price = newPrice;
		}

		public string getModel()
		{
			return this.model;
		}

		public Wood getTopWood()
		{
			return this.topWood;
		}

		public Type getType()
		{
			return this.type;
		}

		public Wood getBackWood()
		{
			return this.backWood;
		}
	}
}
