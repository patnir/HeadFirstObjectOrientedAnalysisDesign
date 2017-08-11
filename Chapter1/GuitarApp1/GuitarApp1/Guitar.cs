using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	


	public class Guitar : Instrument
	{	
		public Guitar(string serialNumber, double price,
			GuitarSpec spec) : base(serialNumber, price, spec)
		{
		}
	}
}
