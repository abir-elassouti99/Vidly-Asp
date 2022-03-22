using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModel;
namespace Vidly1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            var Customers = new List<Customer>() {
            new Customer(){Id=1,Name="Frozen" },
            new Customer(){Id=2,Name="Frozen1" },
            new Customer(){Id=3,Name="Frozen2" },
            new Customer(){Id=4,Name="Frozen3" }
        };
            CustomerMovieViewModel viewModel = new CustomerMovieViewModel()
            {
                Customers = Customers
            };

            return View(viewModel);
        }
        public ActionResult Detail(Customer customer)
        {
            return View(customer);
        }
    }
}