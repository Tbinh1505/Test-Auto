using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class NhanVienRepon : INhanVienRepon
    {
        private BookingAirlineContext _dbContext;
        private List<staff> _lststaff;
        public NhanVienRepon()
        {
            _lststaff = new List<staff>();
            _dbContext = new BookingAirlineContext();
        }

        public NhanVienRepon(BookingAirlineContext bookingAirlineContext)
        {
        }

        public bool addNhanVien(staff sta)
        {
            _dbContext.staff.Add(sta);
            _dbContext.SaveChanges();
            return true;
        }

        public List<staff> getNhanVien()
        {
            _lststaff = _dbContext.staff.ToList();
            return _lststaff;
        }

        public bool updateNhanVien(staff sta)
        {
            _dbContext.staff.Update(sta);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
