namespace LibrarySystem
{
    // First part of partial class
    public partial class LibraryAnalytics
    {
        private static int totalBorrowedItems = 0;

        public static int TotalBorrowedItems
        {
            get { return totalBorrowedItems; }
            set { totalBorrowedItems = value; }
        }

        public static void IncrementBorrowedCount()
        {
            totalBorrowedItems++;
        }
    }
}