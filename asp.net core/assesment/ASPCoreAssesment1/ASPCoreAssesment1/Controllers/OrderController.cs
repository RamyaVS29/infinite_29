using ASPCoreAssesment1.Models;
using ASPCoreAssesment1.Repository;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace ASPCoreAssesment1.Controllers
{
    public class Ordercontroller : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public Ordercontroller(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult PlaceOrder(Order order)
        {
            _orderRepository.PlaceOrder(order);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowOrderDetails(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            return View(order);
        }

        public IActionResult DisplayBill(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            return View(order);
        }

        public IActionResult DisplayCustomerDetails(DateTime orderDate)
        {
            var customer = _orderRepository.GetCustomerByOrderDate(orderDate);
            ViewBag.OrderDate = orderDate.ToShortDateString(); // Pass order date to the view
            return View(customer);
        }


        public IActionResult ShowCustomerWithHighestOrder()
        {
            var customer = _orderRepository.GetCustomerWithHighestOrder();
            return View(customer);
        }

    }

}