using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dog door application");

			DogDoorSimulator.Test1();

			Console.WriteLine("Hit enter to finish");
			Console.ReadLine();
		}
	}
}
