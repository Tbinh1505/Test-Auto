using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class FlightRepo : IFlightRepo
    {
        BookingAirlineContext _context;
        public FlightRepo()
        {
            _context=new BookingAirlineContext();
        }
        public bool create(Flight flight)
        {
            try
            {
                _context.Add(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Flight> get_list()
        {
            return _context.Flights.ToList();
        }

        public bool update(Flight flight)
        {
            try
            {
                _context.Update(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
