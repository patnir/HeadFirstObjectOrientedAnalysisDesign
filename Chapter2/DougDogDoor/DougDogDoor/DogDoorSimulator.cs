using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
			Console.WriteLine("\n\nDog has gone outside");
			remote.pressButton();
			Console.WriteLine("\n\nDog is done");
			remote.pressButton();
			Console.WriteLine("\n\nDog is back inside");
			remote.pressButton();

		}

		public static void Test2()
		{
			DogDoor door = new DogDoor();
			Remote remote = new Remote(door);

			remote.pressButton();
			Console.WriteLine("\n\nDog has gone outside");
			Console.WriteLine("\n\nDog is done");

			try
			{
				Thread.Sleep(5000);
			}
			catch (ThreadInterruptedException e)
			{
				remote.pressButton();
			}

		}
	}
}
