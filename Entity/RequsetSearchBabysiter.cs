using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class RequsetSearchBabysiter
    {
        public int RequsetSearchBabysiterId { get; set; }
        public int SearchBabysiterId { get; set; }
        public int NeighborhoodId { get; set; }
        public string Day { get; set; } = null!;
        public string? PartOfDay { get; set; }
        public int? Price { get; set; }

        public virtual Neighborhood Neighborhood { get; set; } = null!;
        public virtual SearchBabysiter SearchBabysiter { get; set; } = null!;
    }
}
