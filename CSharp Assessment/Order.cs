using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven
{
    public class Order
    {
        public int Id { get; set; }
        public OrderState State { get; set; }

        public Order(int orderId, OrderState state)
        {
            Id = orderId;
            State = state;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {Id}, State: {State}");
        }

        public void changeState(OrderState state )
        {
            State = state;
        }
    }
}
