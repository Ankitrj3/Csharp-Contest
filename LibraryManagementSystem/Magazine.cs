namespace LibrarySystem.Items
{
    public class Magazine : LibraryItem
    {
        public Magazine(string title, string author, int itemId) : base(title, author, itemId)
        {
        }

        public override void DisplayItemDetails()
        {
            Console.WriteLine($"Magazine Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        public override double CalculateLateFee(int days)
        {
            return 0.5 * days; 
        }
    }
}