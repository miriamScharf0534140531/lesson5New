using Bank.Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.BL
{
    public interface IBankService
    {
        List<Customer> GetCustomerData();
    }
}
