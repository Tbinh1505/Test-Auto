using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface IFlightRepo
    {
        public List<Flight> get_list();
        public bool create(Flight flight);
        public bool update(Flight flight);
    }
}
