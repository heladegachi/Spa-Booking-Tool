using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingToolWebAPI.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Treatment")]
        public Nullable<int> TreatmentId { get; set; }

        public int Price { get; set; }
        public int Offline { get; set; }
        public int Cancelled { get; set; }
        public string PreferredBT { get; set; }

        [ForeignKey("AppUser")]
        public string UserID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual AppUser AppUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatments { get; set; }

    }
}
