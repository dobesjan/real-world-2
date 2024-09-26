using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models.Housings
{
	public class Room : WorldObject
	{
		public Coordinates3D Dimensions { get; }

		public Room(Coordinates3D dimensions, Coordinates3D coordinates) : base(coordinates)
		{
			Dimensions = dimensions;
		}
	}
}
