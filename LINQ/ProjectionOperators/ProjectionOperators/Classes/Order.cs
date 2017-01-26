using System;

namespace ProjectionOperators.Classes
{
    public class Order
    {
        public int OrderId;
        public DateTime OrderDate;
        public decimal Total;

        public Order(int orderId, DateTime orderDate, decimal total)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Total = total;
        }

        public Order()
        {

        }
    }
}
