using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp1
{
	public class InstrumentSpec
	{
		private Dictionary<object, object> properties;

		public InstrumentSpec(Dictionary<object, object> properties)
		{
			if (properties == null)
			{
				this.properties = new Dictionary<object, object>();
			}
			else
			{
				this.properties = new Dictionary<object, object>(properties);
			}
		}

		public Dictionary<object, object> getProperties()
		{
			return this.properties;
		}

		public object getProperty(string key)
		{
			return this.properties[key];
		}

		public bool Equals(InstrumentSpec spec)
		{

			foreach (object key in spec.getProperties().Keys) {
				if (!this.properties.ContainsKey(key))
				{
					return false;
				}
				else if (this.properties[key] != spec.getProperty(key))
				{
					return false;
				}
			}
			return true;
		}
	}
}
