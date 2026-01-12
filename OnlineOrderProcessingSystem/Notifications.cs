namespace OnlineOrderProcess
{
    public static class Notifications
    {
        public static void CustomerNotification(Order order, OrderStatus status)
        {
            Console.WriteLine($"Customer notified: Order {order.OrderId} is {status}");
        }

        public static void LogisticsNotification(Order order, OrderStatus status)
        {
            Console.WriteLine($"Logistics notified: Order {order.OrderId} is {status}");
        }
    }
}