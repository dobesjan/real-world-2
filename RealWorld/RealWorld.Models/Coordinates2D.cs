using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models
{
	public class Coordinates2D
	{
		public double X { get; set; }
		public double Y { get; set; }

		public double Perimiter 
		{
			get
			{
				return X * Y;
			}
		}

		public Coordinates2D(double x, double y)
		{
			X = x;
			Y = y;
		}
	}
}
