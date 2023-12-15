using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface ICustomerServices
    {
        public List<Customer> GetCustomers();
        public string Create(Customer cus);
        public string Update(Customer cus);
        public Customer Get(string id);
    }
}
