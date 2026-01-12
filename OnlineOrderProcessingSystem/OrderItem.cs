namespace OnlineOrderProcess
{
    public class OrderItem
    {
        public required Product Product { get; set; }
        public int Quantity { get; set; }
        public double GetTotal()
        {
            return Product.Price * Quantity;
        }
    }
}