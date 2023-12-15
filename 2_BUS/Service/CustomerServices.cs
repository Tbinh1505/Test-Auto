using _1_DAL.Models;
using _1_DAL.Repon;
using _1_DAL.IRepon;
using _2_BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class CustomerServices:ICustomerServices
    {
        CustomerRepo _repo;
        public CustomerServices()
        {
            _repo = new CustomerRepo();
        }
        public string Create(Customer cus)
        {
            if (_repo.Create(cus))
            {
                return "Đăng ký thành công";
            }
            return "Đăng ký thất bại";
        }

        public Customer Get(string id)
        {
            return _repo.Get(id);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public string Update(Customer cus)
        {
            if (_repo.Update(cus))
            {
                return "Cập nhật thành công!";
            }
            return "Cập nhật thất bại";
        }
    }
}
