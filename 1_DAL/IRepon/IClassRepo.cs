using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface IClassRepo
    {
        public List<Class> get_list();
    }
}
