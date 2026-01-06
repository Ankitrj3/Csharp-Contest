namespace LibrarySystem.Items
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemID { get; set; }

        public LibraryItem(string title, string author, int itemId)
        {
            Title = title;
            Author = author;
            ItemID = itemId;
        }
        
        public abstract void DisplayItemDetails();
        public abstract double CalculateLateFee(int days);
    }
}