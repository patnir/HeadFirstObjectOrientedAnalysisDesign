using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class Guitar
	{
		public string serialNumber;
		private string builder;
		private string model;
		private string type;
		private string backWood;
		private string topWood;
		private double price;

		public Guitar(string serialNumber, double price,
			string builder, string model, string type, string backWood,
			string topWood)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.topWood = topWood;
			this.backWood = backWood;
		}

		public string getSerialNumber()
		{
			return this.serialNumber;
		}

		public string getBuilder()
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

		public string getTopWood()
		{
			return this.topWood;
		}

		public string getType()
		{
			return this.type;
		}

		public string getBackWood()
		{
			return this.backWood;
		}
	}
}
