using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class GuitarSpec : InstrumentSpec
	{
		
		private int numStrings;


		public GuitarSpec(Builder builder, string model, Type type, Wood backWood,
			Wood topWood, int numStrings) : base(builder, model, type, backWood, topWood)
		{
			this.numStrings = numStrings;
		}

		public new bool Equals(InstrumentSpec spec)
		{
			if (!base.Equals(spec))
				return false;

			if (!(spec is GuitarSpec))
				return false;

			GuitarSpec gspec = (GuitarSpec)spec;
			if (this.numStrings != gspec.numStrings)
				return false;

			return true;
		}


		public int getNumStrings()
		{
			return this.numStrings;
		}
	}
}
