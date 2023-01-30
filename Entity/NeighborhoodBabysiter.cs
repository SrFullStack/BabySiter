using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class NeighborhoodBabysiter
    {
        public int NeighborhoodBabysiterId { get; set; }
        public int BabysiterId { get; set; }
        public int NeighborhoodId { get; set; }

        public virtual Babysiter Babysiter { get; set; } = null!;
        public virtual Neighborhood Neighborhood { get; set; } = null!;
    }
}
