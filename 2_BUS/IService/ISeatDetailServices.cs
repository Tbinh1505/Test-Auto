using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _2_BUS.IService
{
    public interface ISeatDetailServices
    {
        public string Create(SeatDetail seatDetail);
        public List<SeatDetail> list();
        public string Update(SeatDetail seatDetail);
        public SeatDetail get(int id,string code);
    }
}
