using RealWorld.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models.Housings
{
	public class Land : Estate
	{
		public Land(Person owner, Coordinates3D coordinates, double perimiter) : base(owner, coordinates, perimiter) { }
	}
}
