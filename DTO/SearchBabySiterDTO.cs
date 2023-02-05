using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SearchBabySiterDTO
    {
        public int SearchBabysiterId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; } = null!;
    }
}
