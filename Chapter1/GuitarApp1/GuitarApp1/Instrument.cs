using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public abstract class Instrument
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

		public InstrumentSpec getSpec()
		{
			return spec;
		}
	}
}
