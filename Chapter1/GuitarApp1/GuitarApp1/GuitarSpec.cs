using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class GuitarSpec
	{
		private Builder builder;
		private Type type;
		private Wood backWood;
		private Wood topWood;
		private string model;
		private int numStrings;


		public GuitarSpec(Builder builder, string model, Type type, Wood backWood,
			Wood topWood, int numStrings)
		{
			this.builder = builder;
			this.type = type;
			this.topWood = topWood;
			this.backWood = backWood;
			this.model = model;
			this.numStrings = numStrings;
		}

		public bool Equals(GuitarSpec spec)
		{
			if (this.type != spec.type)
				return false;
			if (this.builder != spec.builder)
				return false;
			if (this.backWood != spec.backWood)
				return false;
			if (this.topWood != spec.topWood)
				return false;
			if (this.numStrings != spec.numStrings)
				return false;
			if (spec.model == null || spec.model == "" || spec.model != this.model)
				return false;
			return true;
		}


		public void print()
		{
			Console.WriteLine(
				this.builder + " " + this.model + " " + this.type + " guitar:\n"
			+ this.numStrings.ToString() + " strings with " + this.backWood + " back and sides, and " + this.topWood + " top.");
		}

		public string getModel()
		{
			return this.model;
		}

		public int getNumStrings()
		{
			return this.numStrings;
		}

		public Builder getBuilder()
		{
			return this.builder;
		}
		public Wood getTopWood()
		{
			return this.topWood;
		}
		public Type getType()
		{
			return this.type;
		}

		public Wood getBackWood()
		{
			return this.backWood;
		}
	}
}
