using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class Inventory
	{
		private LinkedList<Guitar> guitars;

		public void addGuitar(string serialNumber, double price,
			string builder, string model, string type, string backWood,
			string topWood)
		{
			Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
			guitars.AddLast(guitar);
		}

		public Guitar getGuitar(string serialNumber)
		{
			foreach (Guitar g in this.guitars)
			{
				if (g.getSerialNumber() == serialNumber)
				{
					return g;
				}
			}

			return null;
		}

		public Guitar search(Guitar searchGuitar)
		{

			return null;
		}

		public bool compareStrings(string one, string two)
		{
			if (one != null && one != "" && one == two)
			{
				return true;
			}
			return false;
		}
	}
}
