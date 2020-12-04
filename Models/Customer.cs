using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class Customer : User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CreditCard { get; set; }
        //public ICollection<Booking> Bookings { get; set; }
    }


}
