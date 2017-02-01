using System;

namespace CustomSequenceOperators.Classes
{
    class Order
    {
        public Order(int orderId, DateTime orderDate, decimal total)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Total = total;
        }

        public Order() { }

        public int OrderId;
        public DateTime OrderDate;
        public decimal Total;
    }
}
