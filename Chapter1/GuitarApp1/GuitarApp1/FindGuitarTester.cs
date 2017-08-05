using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	class FindGuitarTester
	{
		public static void Test1()
		{
			Inventory inventory = new Inventory();
			initializeInventory(inventory);

			GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
			List<Guitar> matches= inventory.search(whatErinLikes);

			if (matches.Count != 0)
			{
				foreach(Guitar guitar in matches)
					guitar.print();
			}
			else
			{
				Console.WriteLine("We have nothing for you");
			}
		}

		public static void initializeInventory(Inventory inventory)
		{
			inventory.addGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);
			inventory.addGuitar("V95693", 1699.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);

			inventory.addGuitar("V95693", 1599.95, Builder.FENDER, "Stratocastor", Type.ACOUSITC, Wood.ALDER, Wood.CEDAR, 12);
			inventory.addGuitar("V95693", 1799.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);

		}
	}
}
