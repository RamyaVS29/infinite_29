using ASPCoreAssesment1.Models;

namespace ASPCoreAssesment1.Repository
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        void PlaceOrder(Order order);
       
        IEnumerable<Order> GetOrdersByCustomerId(string customerId);
        Customer GetCustomerByOrderDate(DateTime orderDate);
        Customer GetCustomerWithHighestOrder();
    }

}