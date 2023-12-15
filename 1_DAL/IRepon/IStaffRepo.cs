using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRepon
{
    public interface IStaffRepo
    {
        public staff get(int role);

        public staff getEmail(string id);
        public List<staff> list_staff();
        public bool Update(staff staff);
    }
}
