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
    public class FlightServices : IFlightServices
    {
        IFlightRepo _repo;
        public FlightServices()
        {
            _repo = new FlightRepo();
        }
        public string create(Flight flight)
        {
            if (_repo.create(flight))
            {
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public List<Flight> get_list()
        {
           return _repo.get_list();
        }

        public string update(Flight flight)
        {
            if (_repo.update(flight))
            {
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }
    }
}
