using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Recommend
    {
        public int Id { get; set; }
        public long IdFlight { get; set; }
        public string Content { get; set; } = null!;

        public virtual Flight IdFlightNavigation { get; set; } = null!;
    }
}
