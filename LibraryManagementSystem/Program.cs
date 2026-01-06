using LibrarySystem.Items;
using LibrarySystem.Users;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Library Management System Demo ===\n");

            // TASK 1: Abstract Class & Abstract Methods
            Console.WriteLine("TASK 1: Abstract Class & Abstract Methods");
            
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 101);
            Magazine mag1 = new Magazine("National Geographic", "Various Authors", 201);

            book1.DisplayItemDetails();
            Console.WriteLine($"Late fee for 3 days: {book1.CalculateLateFee(3)} units\n");

            mag1.DisplayItemDetails();
            Console.WriteLine($"Late fee for 3 days: {mag1.CalculateLateFee(3)} units\n");

            // TASK 2: Interfaces & Multiple Inheritance
            Console.WriteLine("TASK 2: Interfaces & Multiple Inheritance");
     
            IReservable reservableBook = book1;
            INotifiable notifiableBook = book1;
            
            reservableBook.ReserveItem();
            notifiableBook.SendNotification("Your reservation is confirmed!");
            Console.WriteLine();

            // TASK 3: Dynamic Polymorphism
            Console.WriteLine("TASK 3: Dynamic Polymorphism");
            
            List<LibraryItem> libraryItems = new List<LibraryItem>();
            libraryItems.Add(new Book("1984", "George Orwell", 102));
            libraryItems.Add(new Magazine("Time Magazine", "Time Inc.", 202));

            foreach (LibraryItem item in libraryItems)
            {
                item.DisplayItemDetails(); // Method selection happens at runtime
                Console.WriteLine();
            }

            // TASK 4: Explicit Interface Implementation
            Console.WriteLine("TASK 4: Explicit Interface Implementation");
          
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 103);
            
            // These work - using interface references
            IReservable reservable = book2;
            INotifiable notifiable = book2;
            reservable.ReserveItem();
            notifiable.SendNotification("Book is ready for pickup!");

            // TASK 5: Namespaces & Nested Namespaces
            Console.WriteLine("TASK 5: Namespaces & Nested Namespaces");
           
            // Using full namespace paths to demonstrate nested namespaces
            Book aliasBook = new Book("Pride and Prejudice", "Jane Austen", 104);
            Magazine aliasMag = new Magazine("Scientific American", "Various", 203);
            
            aliasBook.DisplayItemDetails();
            aliasMag.DisplayItemDetails();
            
            Member member1 = new Member("John Doe", 1001, UserRole.Member);
            member1.DisplayMemberInfo();
            

            // TASK 6: Partial & Static Classes
            Console.WriteLine("TASK 6: Partial & Static Classes");
            
            LibraryAnalytics.IncrementBorrowedCount();
            LibraryAnalytics.IncrementBorrowedCount();
            LibraryAnalytics.IncrementBorrowedCount();
            LibraryAnalytics.DisplayAnalytics();
        

            // TASK 7: Enumerations
            Console.WriteLine("TASK 7: Enumerations");
            
            Member librarian = new Member("Jane Smith", 2001, UserRole.Librarian);
            ItemStatus bookStatus = ItemStatus.Available;
            ItemStatus magStatus = ItemStatus.Borrowed;
            
            Console.WriteLine($"User Role: {librarian.Role}");
            Console.WriteLine($"Book Status: {bookStatus}");
            Console.WriteLine($"Magazine Status: {magStatus}");
        }
    }
}