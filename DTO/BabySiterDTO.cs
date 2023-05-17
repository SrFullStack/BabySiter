using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BabySiterDTO
    {


        public int BabysiterId { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;
        [MaxLength(2)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string? Phone { get; set; }
   
        public int Age { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength(2, ErrorMessage = "Password length can't be more than 8")]
        public string Password { get; set; } = null!;
        public string? Description { get; set; }


    }
}
