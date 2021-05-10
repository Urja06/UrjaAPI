using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Model.DTO
{
    public class UserDetailDTO
    {
		public long Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string MobileNumber { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string CityName { get; set; }
		public string IsActive { get; set; }
		public long StateId { get; set; }
		public long CountryId { get; set; }
		public string Address { get; set; }
		public int ZipCode { get; set; }
		public string PassWord { get; set; }
		public string SocialSecurityNumber { get; set; }
		public string ForgotPasswordToken { get; set; }
		public int TotalCount { get; set; }
		public long ROWNUM { get; set; }
	}
}
