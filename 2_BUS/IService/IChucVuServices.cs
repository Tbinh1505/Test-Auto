using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IChucVuServices
    {
        public bool addChucVu(Role cv);
        public bool deleteChucVu(Role cv);
        public bool updateChucVu(Role cv);
        List<Role> getAllChucVu();
    }
}
