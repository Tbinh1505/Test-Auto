using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class ChucVuRepon : IChucVuRepon
    {
        private BookingAirlineContext _dbContext;
        List<Role> _lstCv;
        public ChucVuRepon()
        {
            _dbContext = new BookingAirlineContext();
            _lstCv = new List<Role>();
        }

        public bool addChucVu(Role cv)
        {
            _dbContext.Roles.Add(cv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteChucVu(Role cv)
        {
            _dbContext.Roles.Remove(cv);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Role> getAllChucVu()
        {
            _lstCv = _dbContext.Roles.ToList();
            return _lstCv;
        }

        public bool updateChucVu(Role cv)
        {
            _dbContext.Roles.Update(cv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
