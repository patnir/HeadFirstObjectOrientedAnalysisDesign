using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoor
{
	public class DogDoor
	{
		private bool open;

		public DogDoor()
		{
			open = false;
		}

		public void openDogDoor()
		{
			Console.WriteLine("The dog door opens");
			open = true;
		}

		public void closeDogDoor()
		{
			Console.WriteLine("The dog door closes");
			open= false;
		}

		public bool isOpen()
		{
			return open;
		}
	}
}
