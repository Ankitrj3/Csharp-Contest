using System;
using OnlineOrderProcess;
class Program
{
    static void Main()
    {
        foreach (var order in DataRepository.Orders)
        {
            order.OnStatusChanged += Notifications.CustomerNotification;
            order.OnStatusChanged += Notifications.LogisticsNotification;

            Console.WriteLine($"Order {order.OrderId} for {order.Customer.Name}");
            Console.WriteLine($"Total = {order.GetTotal()}");

            order.ChangeStatus(OrderStatus.Paid);
            order.ChangeStatus(OrderStatus.Packed);
            order.ChangeStatus(OrderStatus.Shipped);
            order.ChangeStatus(OrderStatus.Delivered);

            Console.WriteLine("Status History:");
            foreach (var log in order.History)
            {
                Console.WriteLine($"{log.OldStatus} → {log.NewStatus} at {log.ChangedOn}");
            }
        }
    }
}
