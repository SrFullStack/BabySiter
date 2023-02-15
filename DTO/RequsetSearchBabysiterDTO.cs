using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequsetSearchBabysiterDTO
    {
        public int RequsetSearchBabysiterId { get; set; }
        public int SearchBabysiterId { get; set; }
        public int NeighborhoodId { get; set; }
        public string Day { get; set; } = null!;
        public string? PartOfDay { get; set; }
        public int? Price { get; set; }
    }
}
