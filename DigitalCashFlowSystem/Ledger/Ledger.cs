using System;
using System.Collections.Generic;

/// <summary>
/// Generic ledger class for managing collections of financial transactions
/// Provides functionality to add, retrieve, and calculate totals for transactions
/// </summary>
/// <typeparam name="T">Transaction type that must inherit from Transaction base class</typeparam>
public class Ledger<T> where T : Transaction
{
    /// <summary>
    /// Private collection to store all transactions in this ledger
    /// </summary>
    private List<T> transactions = new List<T>();

    /// <summary>
    /// Adds a new transaction entry to the ledger
    /// </summary>
    /// <param name="entry">Transaction to be added to the ledger</param>
    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }

    /// <summary>
    /// Retrieves all transactions that occurred on a specific date
    /// </summary>
    /// <param name="date">Date to filter transactions by</param>
    /// <returns>List of transactions that match the specified date</returns>
    public List<T> GetTransactionsByDate(DateOnly date)
    {
        List<T> result = new List<T>();
        
        // Filter transactions by matching date
        foreach (T t in transactions)
        {
            if (t.Date == date)
            {
                result.Add(t);
            }
        }
        
        return result;
    }

    /// <summary>
    /// Calculates the total amount of all transactions in the ledger
    /// </summary>
    /// <returns>Sum of all transaction amounts</returns>
    public double CalculateTotal()
    {
        return Helper.CalculateTotalAmount(transactions);
    }
    
    /// <summary>
    /// Retrieves all transactions stored in the ledger
    /// </summary>
    /// <returns>Complete list of all transactions</returns>
    public List<T> GetAll()
    {
        return transactions;
    }
}

