using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Role
    {
        public Role()
        {
            staff = new HashSet<staff>();
        }

        public int Id { get; set; }
        public string? DisplayName { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
