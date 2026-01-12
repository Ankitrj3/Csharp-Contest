namespace OnlineOrderProcess
{
    public class Order
    {
        public int OrderId { get; set; }
        public required Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public OrderStatus CurrentStatus { get; private set; } = OrderStatus.Created;
        public List<OrderStatusLog> History { get; } = new List<OrderStatusLog>();

        public StatusChangedHandler? OnStatusChanged;

        public double GetTotal()
        {
            double total = 0;
            foreach (dynamic item in Items)
            {
                total += item.GetTotal();
            }
            return total;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            if (!IsValidTransition(newStatus))
            {
                Console.WriteLine($"Invalid transition: {CurrentStatus} → {newStatus}");
                return;
            }
            History.Add(new OrderStatusLog
            {
                OldStatus = CurrentStatus,
                NewStatus = newStatus,
                ChangedOn = DateTime.Now
            });

            CurrentStatus = newStatus;
            Console.WriteLine($"Order {OrderId} status changed to {newStatus}");

            OnStatusChanged?.Invoke(this, newStatus);
        }
        private bool IsValidTransition(OrderStatus newStatus)
        {
            if (CurrentStatus == OrderStatus.Cancelled)
                return false;

            if (CurrentStatus == OrderStatus.Created && newStatus == OrderStatus.Paid) return true;
            if (CurrentStatus == OrderStatus.Paid && newStatus == OrderStatus.Packed) return true;
            if (CurrentStatus == OrderStatus.Packed && newStatus == OrderStatus.Shipped) return true;
            if (CurrentStatus == OrderStatus.Shipped && newStatus == OrderStatus.Delivered) return true;
            if (newStatus == OrderStatus.Cancelled) return true;

            return false;
        }
    }
}