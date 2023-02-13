using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TimeDTO
    {

        public int TimeId { get; set; }
        public int BabysiterId { get; set; }
        public string Day { get; set; } = null!;
        public string PartOfDay { get; set; } = null!;
        public int Price { get; set; }


    }
}
