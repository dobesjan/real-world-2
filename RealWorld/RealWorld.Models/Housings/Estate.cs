using RealWorld.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models.Housings
{
	public abstract class Estate : WorldObject
	{
		public Person Owner { get; set; }

		// Perimiter in m2
		private double perimiter;

		public Estate(Person owner, Coordinates3D coordinates) : base(coordinates)
		{
			Owner = owner;
		}

		public Estate(Person owner, Coordinates3D coordinates, double perimiter) : base(coordinates)
		{
			Owner = owner;
			this.perimiter = perimiter;
		}

		public virtual double GetPerimiter()
		{
			return perimiter;
		}
	}
}
