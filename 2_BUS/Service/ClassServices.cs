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
    public class ClassServices : IClassServices
    {
        IClassRepo _repo;
        public ClassServices()
        {
            _repo = new ClassRepo();
        }
        public List<Class> get_list()
        {
            return _repo.get_list();    
        }
    }
}
