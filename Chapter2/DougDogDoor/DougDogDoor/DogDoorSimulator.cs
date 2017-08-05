using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoor
{
	class DogDoorSimulator
	{
		public static void Test1()
		{
			DogDoor door = new DogDoor();
			Remote remote = new Remote(door);

			Console.WriteLine("Dog barks to go outside");
			remote.pressButton();
			Console.WriteLine("Dog has gone outside");
			remote.pressButton();
			Console.WriteLine("Dog is done");
			remote.pressButton();
			Console.WriteLine("Dog is back inside");
			remote.pressButton();

		}
	}
}
