
using ASPCoreAssesment1.Models;
using System;
using System.Data.SqlTypes;
using System.Linq;

namespace ASPCoreAssesment1.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly NorthwindContext _context;

        public OrderRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void PlaceOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetOrdersByCustomerId(string customerId)
        {
            return _context.Orders.Where(o => o.CustomerId == customerId).ToList();
        }

        public Customer GetCustomerByOrderDate(DateTime orderDate)
        {
            if (orderDate < SqlDateTime.MinValue.Value || orderDate > SqlDateTime.MaxValue.Value)
            {
                throw new ArgumentOutOfRangeException(nameof(orderDate), "Order date is out of range.");
            }

            var order = _context.Orders.FirstOrDefault(o => o.OrderDate == orderDate);
            if (order != null)
            {
                return _context.Customers.FirstOrDefault(c => c.CustomerId == order.CustomerId);
            }
            return null;
        }


        public Customer? GetCustomerWithHighestOrder()
        {
            var customerIdWithHighestOrder = _context.Orders
                .GroupBy(o => o.CustomerId)
                .OrderByDescending(g => g.Sum(o => o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice)))
                .Select(g => g.Key)
                .FirstOrDefault();

            if (customerIdWithHighestOrder != null)
            {
                return _context.Customers.FirstOrDefault(c => c.CustomerId == customerIdWithHighestOrder);
            }
            return null;
        }

    }

}
