using Bank.Model.model;
using Bank.Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.BL
{
    internal class BankService : IBankService
    {
        readonly IBankRepository _BankRepository;
        public List<Customer> GetCustomerData()
        {
            return _BankRepository.GetCustomerData();
        }
    }
}
