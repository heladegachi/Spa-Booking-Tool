using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class Employee : User
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public int Available { get; set; }
        
    }
}
