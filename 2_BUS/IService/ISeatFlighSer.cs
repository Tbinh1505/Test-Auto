using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface ISeatFlighSer
    {
        public List<SeatFlight> Get();
        public string Create(SeatFlight sf);
    }
}
