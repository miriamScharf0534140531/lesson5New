using Bank.Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.DAL
{
    public interface IBankRepository
    {
        List<Customer> GetCustomerData();
    }
}
