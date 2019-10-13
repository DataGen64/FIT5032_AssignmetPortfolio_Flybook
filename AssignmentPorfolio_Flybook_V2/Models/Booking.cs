namespace AssignmentPorfolio_Flybook_V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public int NumberOfSeats { get; set; }

        public double PaymentAmount { get; set; }

        public int Flight_id { get; set; }

        [Required]
        [StringLength(128)]
        public string User_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual Rating Rating { get; set; }
    }
}
