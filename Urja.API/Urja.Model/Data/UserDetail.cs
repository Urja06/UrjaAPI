using System;
using System.Collections.Generic;

#nullable disable

namespace Urja.Model.Data
{
    public partial class UserDetail
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public long StateId { get; set; }
        public string CityName { get; set; }
        public int ZipCode { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string ForgotPasswordToken { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? IsConfirm { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string ConfirmToken { get; set; }

        public virtual State State { get; set; }
    }
}
