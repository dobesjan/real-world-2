using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models
{
	public abstract class WorldObject
	{
		public Coordinates3D Coordinates { get; set; }

		public WorldObject(Coordinates3D coordinates)
		{
			Coordinates = coordinates;
		}
	}
}
