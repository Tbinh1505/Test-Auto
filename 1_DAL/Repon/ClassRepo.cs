using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class ClassRepo:IClassRepo
    {
        BookingAirlineContext _context;
        public ClassRepo()
        {
            _context=new BookingAirlineContext();
        }

        public List<Class> get_list()
        {
            return _context.Classes.ToList();
        }
    }
}
