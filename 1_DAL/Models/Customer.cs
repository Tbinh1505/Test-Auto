using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Banks = new HashSet<Bank>();
            Tickets = new HashSet<Ticket>();
        }

        public long Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
