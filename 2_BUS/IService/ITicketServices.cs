using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface ITicketServices
    {
        public List<Ticket> list_Ticket();
        public string add(Ticket ticket);
        public string update(Ticket ticket);
    }
}
