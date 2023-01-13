using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineTicketsApp.Entities
{
    public class Plane
    {
        public Plane()
        { this.Flights = new HashSet<Flight>(); }

        public int Id { get; set; }
        public string Model { get; set; }
        public string ImageURL { get; set; }
        public decimal HandLuggageVolume { get; set; }
        public bool BarOnBoard { get; set; }
        public int SeatsCount { get; set; }

        public HashSet<Flight> Flights{ get; set; }
    }
}
