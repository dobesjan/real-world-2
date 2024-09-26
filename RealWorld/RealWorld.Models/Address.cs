﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Models
{
	public class Address
	{
		public string Street { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public Address(string street, string city, string postalCode, string country) 
		{
			Street = street;
			City = city;
			PostalCode = postalCode;
			Country = country;
		}
	}
}
