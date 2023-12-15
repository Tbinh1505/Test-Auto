using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class BankRepo : IBankRepo
    {
        BookingAirlineContext _context;

        public BankRepo()
        {
            _context = new BookingAirlineContext();
        }
        public bool create(Bank bank)
        {
            try
            {
                _context.Banks.Add(bank);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Bank> List_bank()
        {
            return _context.Banks.ToList();
        }

        public bool update(Bank bank)
        {
            try
            {
                _context.Banks.Update(bank);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
