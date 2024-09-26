using RealWorld.Models.People;

namespace RealWorld.Models.Housings
{
    public class Housing : Estate
	{
        public Address Address { get; }
		public List<Room> Rooms { get; set; }

		public Housing(Address address, List<Room> rooms, Person owner, Coordinates3D coordinates) : base(owner, coordinates)
		{
			Address = address;
			Rooms = rooms;
		}

		public override double GetPerimiter()
		{
			return Rooms.Sum(r => r.Dimensions.Perimiter);
		}
	}
}
