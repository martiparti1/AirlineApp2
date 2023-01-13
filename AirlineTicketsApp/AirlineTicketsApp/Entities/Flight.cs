using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineTicketsApp.Entities
{
    public class Flight
    {
        public Flight()
        { this.Reservations = new HashSet<Reservation>(); }

        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string TakeOffDestination { get; set; }
        public string LandingDestination { get; set; }
        public DateTime TakeOffTime { get; set; }
        public DateTime LandingTime { get; set; }
        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        public decimal TicketPrice { get; set; }
        public double DiscountPercentage { get; set; }

        public HashSet<Reservation> Reservations { get; set; }
    }
}
