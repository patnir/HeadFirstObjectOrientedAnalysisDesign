using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public abstract class InstrumentSpec
	{
		private Builder builder;
		private Type type;
		private Wood backWood;
		private Wood topWood;
		private string model;

		public InstrumentSpec(Builder builder, string model, Type type, Wood backWood,
			Wood topWood)
		{
			this.builder = builder;
			this.type = type;
			this.topWood = topWood;
			this.backWood = backWood;
			this.model = model;
		}


		public bool Equals(InstrumentSpec spec)
		{
			if (this.type != spec.type)
				return false;
			if (this.builder != spec.builder)
				return false;
			if (this.backWood != spec.backWood)
				return false;
			if (this.topWood != spec.topWood)
				return false;
			if (spec.model == null || spec.model == "" || spec.model != this.model)
				return false;
			return true;
		}

	}
}
