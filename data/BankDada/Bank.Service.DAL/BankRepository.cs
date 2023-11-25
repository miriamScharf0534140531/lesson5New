using Bank.Model.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.DAL
{
    public class BankRepository : IBankRepository
    {
        readonly BankContext _BankContext;
        public List<Customer> GetCustomerData()
        {
            return _BankContext.customers.ToList();
        }
    }
}
