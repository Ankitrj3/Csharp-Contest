namespace OnlineOrderProcess
{
    public class OrderStatusLog
    {
        public OrderStatus OldStatus{get; set;}
        public OrderStatus NewStatus{get; set;}
        public DateTime ChangedOn{get; set;}
    }
}