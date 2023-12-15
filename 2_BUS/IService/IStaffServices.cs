using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IStaffServices
    {
        public staff get(int role);
        public List<staff> list_staff();
        public string update(staff staff);

        public staff getEmail(string id);
    }
}
