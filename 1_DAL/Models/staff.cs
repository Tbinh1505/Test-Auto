using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class staff
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string DisplayName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int? Status { get; set; }

        public virtual Role? Role { get; set; }
    }
}
