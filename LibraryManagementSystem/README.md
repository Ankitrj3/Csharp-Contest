# Library Management System - Assignment Solution

This project demonstrates all 7 required tasks for the C# assignment:

## ✅ TASK 1: Abstract Class & Abstract Methods
- **LibraryItem** abstract base class with Title, Author, ItemID properties
- Two abstract methods: DisplayItemDetails() and CalculateLateFee()
- **Book** class (1 unit per day late fee)
- **Magazine** class (0.5 units per day late fee)

## ✅ TASK 2: Interfaces & Multiple Inheritance  
- **IReservable** interface with ReserveItem() method
- **INotifiable** interface with SendNotification() method
- Book class implements both interfaces

## ✅ TASK 3: Dynamic Polymorphism
- Collection of LibraryItem objects
- Runtime method selection demonstrated
- Proper polymorphic behavior shown

## ✅ TASK 4: Explicit Interface Implementation
- Book class uses explicit interface implementation
- Direct access restricted, only accessible via interface references

## ✅ TASK 5: Namespaces & Nested Namespaces
- **LibrarySystem** main namespace
- **LibrarySystem.Items** nested namespace (Book, Magazine)
- **LibrarySystem.Users** nested namespace (Member)
- Namespace alias: `Items = LibrarySystem.Items`

## ✅ TASK 6: Partial & Static Classes
- **LibraryAnalytics** partial class split into two files
- Static property: TotalBorrowedItems
- Static methods: DisplayAnalytics(), IncrementBorrowedCount()

## ✅ TASK 7: Enumerations
- **UserRole** enum: Admin, Librarian, Member
- **ItemStatus** enum: Available, Borrowed, Reserved, Lost

## How to Run
```bash
cd LibraryManagementSystem
dotnet run
```

The program demonstrates all requirements with clear output showing each task's functionality.