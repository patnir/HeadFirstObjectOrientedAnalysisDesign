using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DougDogDoor
{
	public class Remote
	{
		private DogDoor door;

		public Remote(DogDoor door)
		{
			this.door = door;
		}

		public void pressButton()
		{
			Console.WriteLine("Pressing the remote control button...");
			if (door.isOpen())
			{
				door.closeDogDoor();
			}
			else
			{
				door.openDogDoor();

				Thread.Sleep(2000);

				door.closeDogDoor();
			}
		}

		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Console.WriteLine("Testing");
			
		}
	}
}
