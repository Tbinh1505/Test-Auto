using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class PlaneType
    {
        public PlaneType()
        {
            Flights = new HashSet<Flight>();
            SeatDetails = new HashSet<SeatDetail>();
        }

        public long Id { get; set; }
        public string PlaneCode { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int TotalSeat { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<SeatDetail> SeatDetails { get; set; }
    }
}
