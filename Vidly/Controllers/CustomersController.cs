using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Detail(int Id)
        {
            var customer = GetCustomers().FirstOrDefault(p => p.Id == Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id =1, Name = "John Smith" },
                new Customer { Id =2, Name = "Mary Willams" }
            };
            return customers;
        }
    }
}