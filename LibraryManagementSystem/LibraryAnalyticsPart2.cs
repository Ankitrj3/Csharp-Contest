namespace LibrarySystem
{
    // Second part of partial class
    public partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
            Console.WriteLine($"Library Analytics:");
            Console.WriteLine($"Total Borrowed Items: {TotalBorrowedItems}");
        }

        public static void ResetAnalytics()
        {
            totalBorrowedItems = 0;
            Console.WriteLine("Analytics have been reset.");
        }
    }
}