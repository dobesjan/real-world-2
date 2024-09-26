using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models.Parameters
{
	public class Parameter<T>
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public T Value { get; set; }
	}
}
