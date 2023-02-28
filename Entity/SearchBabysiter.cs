using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class SearchBabysiter
    {
        public SearchBabysiter()
        {
            RequsetSearchBabysiters = new HashSet<RequsetSearchBabysiter>();
        }

        public int SearchBabysiterId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<RequsetSearchBabysiter> RequsetSearchBabysiters { get; set; }
    }
}
