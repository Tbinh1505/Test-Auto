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
    public class NhanVienServices: INhanVienServices
    {
        IChucVuRepon _IChucVuRepon;
        INhanVienRepon _INhanVienRepon;
        List<staff> _lststaff;
        public NhanVienServices()
        {
            _lststaff = new List<staff>();
            _IChucVuRepon = new ChucVuRepon();
            _INhanVienRepon = new NhanVienRepon();
        }

        public string addNhanVien(staff nhanVien)
        {

            if (_INhanVienRepon.addNhanVien(nhanVien))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm không thành công";
            }
        }

        public List<staff> getAllNhanVien()
        {
            _lststaff = _INhanVienRepon.getNhanVien().ToList();
            return _lststaff;
        }

        public string updateNhanVien(staff nhanVien)
        {
            if (_INhanVienRepon.updateNhanVien(nhanVien))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa không thành công";
            }
        }
    }
    
}
