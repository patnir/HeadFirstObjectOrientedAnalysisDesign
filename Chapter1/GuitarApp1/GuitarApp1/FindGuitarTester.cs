using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	class FindGuitarTester
	{
		private const string instrumentType = "instrumentType";
		private const string model = "model";
		private const string builder = "builder";
		private const string type = "type";
		private const string numStrings = "numStrings";
		private const string topWood = "topWood";
		private const string backWood = "backWood";


		public static void Test1()
		{
			Inventory inventory = new Inventory();
			initializeInventory(inventory);

			
		}

		public static void initializeInventory(Inventory inventory)
		{
			Dictionary<object, object> map = new Dictionary<object, object>();

			map.Add("instrumentType", InstrumentType.GUITAR);
			map.Add(type, Type.ACOUSITC);
			map.Add(model, "Strat");
			map.Add(topWood, Wood.ADIRONDACK);
			map.Add(backWood, Wood.ADIRONDACK);

		}
	}
}
