using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Time
    {
        public int TimeId { get; set; }
        public int BabysiterId { get; set; }
        public string Day { get; set; } = null!;
        public string PartOfDay { get; set; } = null!;
        public int Price { get; set; }

        public virtual Babysiter Babysiter { get; set; } = null!;
    }
}
