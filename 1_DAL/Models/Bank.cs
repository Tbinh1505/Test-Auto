using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Bank
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public string DisplayName { get; set; } = null!;
        public long BankAccountNum { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
