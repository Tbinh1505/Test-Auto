using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepon
{
    public interface ICustomerRepo
    {
        public List<Customer> GetCustomers();
        public bool Create(Customer cus);
        public bool Update(Customer cus);
        public Customer Get(string id);
    }
}
