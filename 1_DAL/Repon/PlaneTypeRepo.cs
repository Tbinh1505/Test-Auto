using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class PlaneTypeRepo : IPlaneTypeRepo
    {
        BookingAirlineContext _context;
        public PlaneTypeRepo()
        {
            _context=new BookingAirlineContext();
        }

        public bool create(PlaneType plane)
        {
            try
            {
                _context.PlaneTypes.Add(plane);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PlaneType> get_list()
        {
            return _context.PlaneTypes.ToList();
        }

        public bool update(PlaneType plane)
        {
            try
            {
                _context.PlaneTypes.Update(plane);
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
