using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IPlaneTypeServices
    {
        public List<PlaneType> get_list();
        public string create(PlaneType plane);
        public string update(PlaneType plane);
    }
}
