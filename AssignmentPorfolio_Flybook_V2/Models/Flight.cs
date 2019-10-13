namespace AssignmentPorfolio_Flybook_V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        public int FlightId { get; set; }

        public int AvailableSeats { get; set; }

        [Column(TypeName = "date")]
        public DateTime DepartureDate { get; set; }

        public TimeSpan DepartureTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime ArrivalDate { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        [Required]
        public string Departure_Loc { get; set; }

        [Required]
        public string Arrival_Loc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal From_Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal From_Longitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal To_Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal To_Longitude { get; set; }

        public double FairPrice { get; set; }

        [Required]
        public string FlightNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
