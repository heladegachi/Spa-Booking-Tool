using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class Treatment
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public string Picture { get; set; }
    }
}
