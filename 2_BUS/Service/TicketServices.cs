using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class TicketServices : ITicketServices
    {
        ITicketRepo _repo;
        public TicketServices()
        {
            _repo=new TicketRepo();
        }
        public string add(Ticket ticket)
        {
            if (_repo.AddTicket(ticket))
            {
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public List<Ticket> list_Ticket()
        {
            return _repo.GetTickets();
        }

        public string update(Ticket ticket)
        {
            if (_repo.UpdateTicket(ticket))
            {
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }
    }
}
