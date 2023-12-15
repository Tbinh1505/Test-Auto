using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class SeatFlightRepo : ISeatFlight
    {
        BookingAirlineContext _context;
        public SeatFlightRepo()
        {
            _context = new();
        }
        public bool Create(SeatFlight sf)
        {
            try
            {
                _context.SeatFlights.Add(sf);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SeatFlight> Get()
        {
            
            return _context.SeatFlights.ToList();
        }
    }
}
