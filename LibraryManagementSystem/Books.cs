namespace LibrarySystem.Items
{
    public class Book : LibraryItem, IReservable, INotifiable
    {
        public Book(string title, string author, int itemId) : base(title, author, itemId)
        {
        }

        public override void DisplayItemDetails()
        {
            Console.WriteLine($"Book Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        public override double CalculateLateFee(int days)
        {
            return 1.0 * days; 
        }

        void IReservable.ReserveItem()
        {
            Console.WriteLine($"Book '{Title}' has been successfully reserved.");
        }

        void INotifiable.SendNotification(string message)
        {
            Console.WriteLine($"Notification sent for book '{Title}': {message}");
        }
    }
}