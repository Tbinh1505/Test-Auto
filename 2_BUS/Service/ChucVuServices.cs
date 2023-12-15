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
    public class ChucVuServices : IChucVuServices
    {

        private IChucVuRepon _ichuVuRepon;
        private List<Role> _lstCV;
        public ChucVuServices()
        {
            _ichuVuRepon = new ChucVuRepon();
            _lstCV = new List<Role>();
        }
        public bool addChucVu(Role cv)
        {
            _ichuVuRepon.addChucVu(cv);

            return true;
        }

        public bool deleteChucVu(Role cv)
        {
            _ichuVuRepon.deleteChucVu(cv);
            return true;
        }

        public List<Role> getAllChucVu()
        {
            _lstCV = _ichuVuRepon.getAllChucVu();
            return _lstCV;
        }

        public bool updateChucVu(Role cv)
        {
            _ichuVuRepon.updateChucVu(cv);
            return true;
        }
    }
}
