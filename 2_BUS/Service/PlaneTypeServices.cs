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
    public class PlaneTypeServices : IPlaneTypeServices
    {
        IPlaneTypeRepo _repo;
        public PlaneTypeServices()
        {
            _repo= new PlaneTypeRepo();
        }

        public string create(PlaneType plane)
        {
            if (_repo.create(plane))
            {
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public List<PlaneType> get_list()
        {
            return _repo.get_list();
        }

        public string update(PlaneType plane)
        {
            if (_repo.update(plane))
            {
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }
    }
}
