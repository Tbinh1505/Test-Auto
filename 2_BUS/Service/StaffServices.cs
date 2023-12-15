using _1_DAL.IRepon;
using _1_DAL.Repon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IService;

namespace _2_BUS.Service
{
    public class StaffServices : IStaffServices
    {
        IStaffRepo _repo;
        public StaffServices()
        {
            _repo=new StaffRepo();
        }
        public staff get(int role)
        {
            return _repo.get(role);
        }

        public staff getEmail(string id)
        {
            return _repo.getEmail(id);
        }

        public List<staff> list_staff()
        {
            return _repo.list_staff();
        }

        public string update(staff staff)
        {
            if (_repo.Update(staff))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật không thành công";
        }
    }
}
