using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class LocationRepo : ILocationRepo
    {
        BookingAirlineContext _context;
        public LocationRepo()
        {
            _context=new BookingAirlineContext();
        }

        public List<Airport> list_loca()
        {
            return _context.Airports.ToList();
        }
    }
}
