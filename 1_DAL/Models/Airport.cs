using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Airport
    {
        public Airport()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string AirportCode { get; set; } = null!;
        public string AirportName { get; set; } = null!;
        public string LocationFly { get; set; } = null!;

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
