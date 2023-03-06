using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GetAllBaby
    {
        public int BabysiterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Description { get; set; }
        public int NeighborhoodId { get; set; }
        public string Day { get; set; } = null!;
        public string PartOfDay { get; set; } = null!;
        public int Price { get; set; }
    }
}
