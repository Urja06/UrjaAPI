using System;
using System.Collections.Generic;

#nullable disable

namespace Urja.Model.Data
{
    public partial class City
    {
        public string Id { get; set; }
        public long StateId { get; set; }
        public string Name { get; set; }

        public virtual State State { get; set; }
    }
}
