using System;

/// <summary>
/// Main program class for the Digital Cash Flow System
/// Manages income and expense transactions, calculates totals, and displays financial summaries
/// </summary>
class Program
{
    /// <summary>
    /// Entry point of the application
    /// Initializes ledgers, loads transaction data, calculates remaining balance, and displays transaction history
    /// </summary>
    static void Main()
    {
        // Initialize separate ledgers for income and expense transactions using generic types
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        // Load sample transaction data from the data bank
        dynamic incomes = DataBank.GetIncomeData();
        dynamic expenses = DataBank.GetExpenseData();

        // Populate income ledger with all income transactions
        foreach(dynamic income in incomes)
        {
            incomeLedger.AddEntry(income);
        }
        
        // Populate expense ledger with all expense transactions
        foreach(dynamic expense in expenses)
        {
            expenseLedger.AddEntry(expense);
        }

        // Calculate total income and expenses
        dynamic incomeTotal = incomeLedger.CalculateTotal();
        dynamic expenseTotal = expenseLedger.CalculateTotal();
        
        // Calculate and display the remaining balance after all expenses
        double RemainingAmount = Helper.CalculateRemaining(incomeTotal, expenseTotal);
        Console.WriteLine($"The Total Income : {incomeTotal}");
        Console.WriteLine($"The Total Expense : {expenseTotal}");
        Console.WriteLine($"Remaining Amount After Expense : {RemainingAmount}");
        
        // Display detailed summary of all income transactions
        Console.WriteLine("\n=== INCOME HISTORY ===");
        foreach(dynamic incomeHis in incomes)
        {
            Console.WriteLine(incomeHis.GetSummary());
        }
        
        // Display detailed summary of all expense transactions
        Console.WriteLine("\n=== EXPENSE HISTORY ===");
        foreach(dynamic expenseHis in expenses)
        {
            Console.WriteLine(expenseHis.GetSummary());
        }
        // Display the History of Transaction based on Date
        string DatePassHistory = "01/01/2026";
        dynamic pastIncomeHistory = incomeLedger.GetTransactionsByDate(DateOnly.Parse(DatePassHistory));
        foreach(dynamic IncomeByDate in pastIncomeHistory)
        {
            Console.WriteLine("Income Get By Date");
            Console.WriteLine(IncomeByDate.GetSummary());
        }
    }
}
