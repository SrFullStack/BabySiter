using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Neighborhood
    {
        public Neighborhood()
        {
            NeighborhoodBabysiters = new HashSet<NeighborhoodBabysiter>();
            RequsetSearchBabysiters = new HashSet<RequsetSearchBabysiter>();
        }

        public int NeighborhoodId { get; set; }
        public string NeighborhoodName { get; set; } = null!;

        public virtual ICollection<NeighborhoodBabysiter> NeighborhoodBabysiters { get; set; }
        public virtual ICollection<RequsetSearchBabysiter> RequsetSearchBabysiters { get; set; }
    }
}
