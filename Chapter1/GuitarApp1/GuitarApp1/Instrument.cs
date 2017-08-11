using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class Instrument
	{
		private string serialNumber;
		private double price;
		private InstrumentSpec spec;

		public Instrument(string serialNumber, double price, InstrumentSpec spec)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.spec = spec;
		}

		public string getSerialNumber()
		{
			return this.serialNumber;
		}

		public double getPrice()
		{
			return this.price;	
		}

		public InstrumentSpec getSpec()
		{
			return spec;
		}


		//public new bool Equals(InstrumentSpec spec)
		//{
		//	if (!base.Equals(spec))
		//		return false;

		//	if (!(spec is GuitarSpec))
		//		return false;

		//	GuitarSpec gspec = (GuitarSpec)spec;
		//	if (this.numStrings != gspec.numStrings)
		//		return false;

		//	return true;
		//}
	}
}
