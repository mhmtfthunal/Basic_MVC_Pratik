using Microsoft.AspNetCore.Mvc;
using Basic_MVC_Pratik.Models;
using Basic_MVC_Pratik.ViewModels;

namespace Basic_MVC_Pratik.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Mehmet Fatih",
                LastName = "Ünal",
                Email = "mehmet@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Kablosuz Mouse", Price = 450m,  Quantity = 1 },
                new Order { Id = 102, ProductName = "Mekanik Klavye", Price = 1550m, Quantity = 1 },
                new Order { Id = 103, ProductName = "Type-C Kablo",   Price = 120m,  Quantity = 2 },
            };

            var vm = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(vm);
        }
    }
}
