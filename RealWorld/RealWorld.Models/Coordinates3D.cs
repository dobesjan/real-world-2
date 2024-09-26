using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models
{
	public class Coordinates3D : Coordinates2D
	{
		public double Z { get; set; }

		public double Volume 
		{ 
			get
			{
				return X * Y * Z;
			}
		}

		public Coordinates3D(double x, double y, double z) : base(x, y)
		{
			Z = z;
		}
	}
}
