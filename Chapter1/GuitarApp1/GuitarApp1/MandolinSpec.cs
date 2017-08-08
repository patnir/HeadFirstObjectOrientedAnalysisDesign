using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public enum Style {
		A, F
	}

	public class MandolinSpec : InstrumentSpec
	{
		private Style style;


		public MandolinSpec(Builder builder, string model, Type type, Wood backWood,
			Wood topWood, Style style) : base(builder, model, type, backWood, topWood)
		{
			this.style = style;
		}

		public new bool Equals(InstrumentSpec spec)
		{
			if (!base.Equals(spec))
				return false;

			if (!(spec is MandolinSpec))
				return false;

			MandolinSpec gspec = (MandolinSpec)spec;
			if (this.style != gspec.style)
				return false;

			return true;
		}
	}

}
