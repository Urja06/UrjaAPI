using System;
using System.Collections.Generic;

#nullable disable

namespace Urja.Model.Data
{
    public partial class UserDetailView
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string SocialSecurityNumber { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public string CityName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
