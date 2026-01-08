using System;
using System.Collections.Generic;

/// <summary>
/// Static data repository class providing sample financial transaction data
/// Contains predefined income and expense transactions for demonstration purposes
/// </summary>
public static class DataBank
{
    /// <summary>
    /// Provides sample income transaction data for the cash flow system
    /// </summary>
    /// <returns>List of predefined income transactions including salary, freelance work, and investments</returns>
    public static List<IncomeTransaction> GetIncomeData()
    {
        return new List<IncomeTransaction>
        {
            // Monthly salary income
            new IncomeTransaction { Id = 1, Date = new DateOnly(2026, 1, 1), Amount = 5000, Source = "Salary", Description = "Monthly salary" },
            
            // Freelance project income
            new IncomeTransaction { Id = 2, Date = new DateOnly(2026, 1, 5), Amount = 1200, Source = "Freelance", Description = "Web development project" },
            
            // Investment dividend income
            new IncomeTransaction { Id = 3, Date = new DateOnly(2026, 1, 7), Amount = 500, Source = "Investment", Description = "Dividend income" }
        };
    }

    /// <summary>
    /// Provides sample expense transaction data for the cash flow system
    /// </summary>
    /// <returns>List of predefined expense transactions covering various categories like rent, groceries, utilities, etc.</returns>
    public static List<ExpenseTransaction> GetExpenseData()
    {
        return new List<ExpenseTransaction>
        {
            // Housing expense - monthly rent
            new ExpenseTransaction { Id = 4, Date = new DateOnly(2026, 1, 2), Amount = 1200, Category = "Rent", Description = "Monthly rent payment" },
            
            // Food expense - weekly groceries
            new ExpenseTransaction { Id = 5, Date = new DateOnly(2026, 1, 3), Amount = 300, Category = "Groceries", Description = "Weekly grocery shopping" },
            
            // Utility expenses
            new ExpenseTransaction { Id = 6, Date = new DateOnly(2026, 1, 4), Amount = 150, Category = "Utilities", Description = "Electricity and water bill" },
            
            // Transportation costs
            new ExpenseTransaction { Id = 7, Date = new DateOnly(2026, 1, 6), Amount = 80, Category = "Transportation", Description = "Fuel and parking" },
            
            // Entertainment expenses
            new ExpenseTransaction { Id = 8, Date = new DateOnly(2026, 1, 7), Amount = 200, Category = "Entertainment", Description = "Movie and dinner" }
        };
    }
}
