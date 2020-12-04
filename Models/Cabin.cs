using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class Cabin
    {
        [Key]
        public int Id { get; set; }
        public string CabinName { get; set; }
        public string State { get; set; }
        public int Available { get; set; }
    }
}
