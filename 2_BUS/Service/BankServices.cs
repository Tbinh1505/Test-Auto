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
    public class BankServices : IBankServices
    {
        IBankRepo _repo;
        public BankServices()
        {
            _repo = new BankRepo();
        }

        public string create(Bank bank)
        {
            if (_repo.create(bank))
            {
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public List<Bank> List_bank()
        {
            return _repo.List_bank();
        }

        public string update(Bank bank)
        {
            if (_repo.update(bank))
            {
                return "Sửa thành công";
            }
            return "Sửa thành công";
        }
    }
}
