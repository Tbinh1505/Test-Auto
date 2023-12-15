using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
namespace _2_BUS.Service
{
    public class SeatDetailServices : ISeatDetailServices
    {
        ISeatDetailRepo _repo;
        public SeatDetailServices()
        {
            _repo=new SeatDetailRepo();
        }
        public string Create(SeatDetail seatDetail)
        {
            if (_repo.Create(seatDetail))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm không thành công";
            }    
        }

        public SeatDetail get(int id, string code)
        {
            return _repo.get(id, code);
        }

        public List<SeatDetail> list()
        {
            return _repo.get_list();
        }

        public string Update(SeatDetail seatDetail)
        {
            if (_repo.Update(seatDetail))
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
