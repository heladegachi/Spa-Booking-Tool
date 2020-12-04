using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Username { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }



    }
}
