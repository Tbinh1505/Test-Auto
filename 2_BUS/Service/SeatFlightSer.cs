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
    public class SeatFlightSer : ISeatFlighSer
    {
        SeatFlightRepo _repo;
        public SeatFlightSer()
        {
           _repo = new SeatFlightRepo();
        }
        public string Create(SeatFlight sf)
        {
            if (_repo.Create(sf))
            {
                return "ok";
            }
            return "false";
        }

        public List<SeatFlight> Get()
        {
            return _repo.Get();
        }
    }
}
