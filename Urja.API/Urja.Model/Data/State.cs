using System;
using System.Collections.Generic;

#nullable disable

namespace Urja.Model.Data
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            UserDetails = new HashSet<UserDetail>();
        }

        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
