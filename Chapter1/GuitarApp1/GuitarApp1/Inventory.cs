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
			Wood topWood, int numStrings = 6)
		{
			Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood, numStrings);
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

		public List<Guitar> search(GuitarSpec searchGuitar)
		{
			List<Guitar> matches = new List<Guitar>();
			foreach (Guitar guitar in this.guitars)
			{
				GuitarSpec spec = guitar.getGuitarSpec();
				if (searchGuitar.Equals(spec))
					matches.Add(guitar);
			}
			return matches;
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
