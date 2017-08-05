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

		public Inventory()
		{
			guitars = new LinkedList<Guitar>();
		}

		public void addGuitar(string serialNumber, double price,
			Builder builder, string model, Type type, Wood backWood,
			Wood topWood)
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
			foreach (Guitar g in this.guitars)
			{
				if (g.getBuilder() != searchGuitar.getBuilder())
					continue;
				if (g.getType() != searchGuitar.getType())
					continue;
				if (g.getBackWood() != searchGuitar.getBackWood())
					continue;
				if (g.getTopWood() != searchGuitar.getTopWood())
					continue;
				string model = g.getModel();
				if (compareStrings(model, searchGuitar.getModel()) == false)
					continue;
				return g;
			}
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
