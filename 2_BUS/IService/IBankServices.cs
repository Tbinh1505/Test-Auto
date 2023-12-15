using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IBankServices
    {
        string create(Bank bank);
        string update(Bank bank);
        List<Bank> List_bank();
    }
}
