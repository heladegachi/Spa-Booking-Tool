using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class BookingToolContext: IdentityDbContext
    {
        public BookingToolContext(DbContextOptions<BookingToolContext> options): base (options)
        {

        }


        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
