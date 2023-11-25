using Bank.Model.model;
using Bank.Service.BL;
using Microsoft.AspNetCore.Mvc;

namespace BankDada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : Controller
    {
        readonly IBankService _BankService;

        public BankController(IBankService bankService)
        {
            _BankService = bankService;
        }
        [HttpGet]
        public List<Customer> Get()
        {
            return _BankService.GetCustomerData();
        }
    }
}
