using Basic_MVC_Pratik.Models;

namespace Basic_MVC_Pratik.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public decimal GrandTotal => Orders?.Sum(o => o.LineTotal) ?? 0m;
    }
}
