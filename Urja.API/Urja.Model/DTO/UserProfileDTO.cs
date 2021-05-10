using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Model.DTO
{
    public class UserProfileDTO
    {
		public long Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public int ZipCode { get; set; }
		public string CityName { get; set; }
		public string SocialSecurityNumber { get; set; }
	}
}
