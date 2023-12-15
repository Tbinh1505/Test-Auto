using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class SeatFlight
    {
        public int Id { get; set; }
        public long? Flightid { get; set; }
        public int? Seatid { get; set; }
        public int? Status { get; set; }

        public virtual Flight? Flight { get; set; }
        public virtual SeatDetail? Seat { get; set; }
    }
}
