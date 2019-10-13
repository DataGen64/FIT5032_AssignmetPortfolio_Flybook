namespace AssignmentPorfolio_Flybook_V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rating")]
    public partial class Rating
    {
        [Key]
        public int Booking_id { get; set; }

        public DateTime RatingDate { get; set; }

        public int RatingProvided { get; set; }

        [Required]
        public string Comments { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
