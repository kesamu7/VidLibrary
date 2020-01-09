using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLibrary.Models;
using VidLibrary.ViewModels;

namespace VidLibrary.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Williams"}
            };

            var viewModel = new CustomerViewModel()
            {
                Customers = customers
            };
            
            return View(viewModel);
        }
    }
}