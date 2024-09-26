using RealWorld.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models.People
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }

		public Address Address { get; set; }

		public List<Parameter<int>> Abilities { get; set; }

		public List<Parameter<int>> Needs { get; set; }

		public Person(string firstName, string lastName, string phoneNumber, Address address)
		{
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Address = address;
		}
	}
}
