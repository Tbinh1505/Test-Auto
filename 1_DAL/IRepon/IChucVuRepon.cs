using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface IChucVuRepon
    {
        public bool addChucVu(Role cv);
        public bool deleteChucVu(Role cv);
        public bool updateChucVu(Role cv);
        public List<Role> getAllChucVu();
    }
}
