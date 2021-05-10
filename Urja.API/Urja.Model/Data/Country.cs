using System;
using System.Collections.Generic;

#nullable disable

namespace Urja.Model.Data
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
