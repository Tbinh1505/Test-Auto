using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface IBankRepo
    {
        bool create(Bank bank);
        bool update(Bank bank);
        List<Bank> List_bank();

    }
}
