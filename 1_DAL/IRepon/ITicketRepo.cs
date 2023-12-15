using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface ITicketRepo
    {
        public List<Ticket> GetTickets();
        public bool UpdateTicket(Ticket ticket);
        public bool AddTicket(Ticket ticket);

    }
}
