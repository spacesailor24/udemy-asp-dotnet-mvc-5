using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        public ActionResult Index()
        {
            var accountCustomers = new List<Customer>
            {
                new Customer { Name = "Todd Berry", Id = 1},
                new Customer { Name = "Sarah Candle", Id = 2}
            };
            
            var viewmodel = new CustomersViewModel()
            {
                customers = accountCustomers
            };

            return View(viewmodel);
        }

        [Route("customers/{id:regex(\\d+)}")]
        public ActionResult Show(int id)
        {
            var accountCustomers = new List<Customer>
            {
                new Customer { Name = "Todd Berry", Id = 1},
                new Customer { Name = "Sarah Candle", Id = 2}
            };

            var foundCustomer = accountCustomers.Find(customer => customer.Id == id);

            return View(foundCustomer);
        }
    }
}