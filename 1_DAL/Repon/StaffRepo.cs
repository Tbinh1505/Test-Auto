using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRepon;
using _1_DAL.Models;

namespace _1_DAL.Repon
{
    public class StaffRepo : IStaffRepo
    {
        BookingAirlineContext _context;
        public StaffRepo() 
        {
            _context=new BookingAirlineContext();
        }
        public staff get(int role)
        {
            return _context.staff.Where(c => c.RoleId==role).FirstOrDefault();
        }

        public staff getEmail(string id)
        {
            return _context.staff.Where(c=> c.Email == id).FirstOrDefault();
        }

        public List<staff> list_staff()
        {
            return _context.staff.ToList();
        }

        public bool Update(staff staff)
        {
            try
            {
                _context.staff.Update(staff);
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
