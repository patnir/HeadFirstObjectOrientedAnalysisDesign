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
				Console.WriteLine("found count = {0}", matches.Count);
			}
			else
			{
				Console.WriteLine("We have nothing for you");
			}
		}

		public static void initializeInventory(Inventory inventory)
		{
			GuitarSpec spec = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
			inventory.addInstrument("V95693", 1499.95, spec);
			MandolinSpec mspec = new MandolinSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, Style.A);
			inventory.addInstrument("V95693", 1699.95, mspec);
			spec = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
			inventory.addInstrument("V95693", 1599.95, spec);
			spec = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ACOUSITC, Wood.ALDER, Wood.ALDER, 6);
			inventory.addInstrument("V95693", 1799.95, spec);

		}
	}
}
