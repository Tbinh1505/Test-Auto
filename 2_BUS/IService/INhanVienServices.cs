using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface INhanVienServices
    {
       public string addNhanVien(staff nhanVien);

        public string updateNhanVien(staff nhanVien);
        public List<staff> getAllNhanVien(); 
    }
}
