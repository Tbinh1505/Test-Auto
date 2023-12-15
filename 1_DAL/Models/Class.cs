using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Class
    {
        public Class()
        {
            SeatDetails = new HashSet<SeatDetail>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; } = null!;
        public int Price { get; set; }

        public virtual ICollection<SeatDetail> SeatDetails { get; set; }
    }
}
