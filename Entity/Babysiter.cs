using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Babysiter
    {
        public Babysiter()
        {
            NeighborhoodBabysiters = new HashSet<NeighborhoodBabysiter>();
            Times = new HashSet<Time>();
        }
        //
        public int BabysiterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public int? NumOfOpinion { get; set; }

        public virtual ICollection<NeighborhoodBabysiter> NeighborhoodBabysiters { get; set; }
        public virtual ICollection<Time> Times { get; set; }
    }
}
