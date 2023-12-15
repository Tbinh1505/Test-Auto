using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Recommends = new HashSet<Recommend>();
            SeatFlights = new HashSet<SeatFlight>();
            Tickets = new HashSet<Ticket>();
        }

        public long Id { get; set; }
        public long PlaneTypeId { get; set; }
        public int LocationId { get; set; }
        public string FlightCode { get; set; } = null!;
        public string GoFrom { get; set; } = null!;
        public string GoTom { get; set; } = null!;
        public int Price { get; set; }
        public DateTime DateFlight { get; set; }
        public DateTime? DateTo { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public int Status { get; set; }

        public virtual Airport Location { get; set; } = null!;
        public virtual PlaneType PlaneType { get; set; } = null!;
        public virtual ICollection<Recommend> Recommends { get; set; }
        public virtual ICollection<SeatFlight> SeatFlights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
