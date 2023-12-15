using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IFlightServices
    {
        public List<Flight> get_list();
        public string create(Flight flight);
        public string update(Flight flight);
    }
}
