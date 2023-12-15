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
    public class LocationService : ILocationServices
    {
        ILocationRepo _repo;
        public LocationService()
        {
            _repo = new LocationRepo();
        }
        public List<Airport> get_list()
        {
            return _repo.list_loca();
        }
    }
}
