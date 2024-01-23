using EventDriven;

public enum OrderState
{
    Created,
    Accepted,
    Verified,
    Processing,
    Completed,
    Rejected
}

public class Program
{
    public static void Main()
    {
        Random random = new Random();

        Order order1 = new Order(1, OrderState.Verified);
        Order order2 = new Order(2, OrderState.Processing);

        while (true)
        {
            int randomNumber = random.Next(10);
            int randomNumber1 = random.Next(10);

            OrderState newState = (OrderState)(randomNumber % Enum.GetValues(typeof(OrderState)).Length);
            OrderState newState1 = (OrderState)(randomNumber1 % Enum.GetValues(typeof(OrderState)).Length);

            order1.State = newState;
            order2.State = newState1;

            Console.WriteLine($"After change :");
            order1.DisplayOrderDetails();
            order2.DisplayOrderDetails();
            Console.WriteLine();
        }
       
       
    }
}