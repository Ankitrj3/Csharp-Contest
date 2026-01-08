/// <summary>
/// Static helper class providing utility methods for financial calculations
/// Contains methods for calculating totals and remaining balances
/// </summary>
public static class Helper
{
    /// <summary>
    /// Calculates the total amount from a list of transactions
    /// </summary>
    /// <typeparam name="T">Transaction type that inherits from Transaction base class</typeparam>
    /// <param name="transactions">List of transactions to calculate total for</param>
    /// <returns>Sum of all transaction amounts as double</returns>
    public static double CalculateTotalAmount<T>(List<T> transactions) where T : Transaction
    {
        double total = 0;
        
        // Iterate through all transactions and sum their amounts
        foreach (Transaction t in transactions)
        {
            total += t.Amount;
        }   
        
        return total;
    }
    
    /// <summary>
    /// Calculates the remaining balance after subtracting expenses from income
    /// </summary>
    /// <param name="income">Total income amount</param>
    /// <param name="expense">Total expense amount</param>
    /// <returns>Remaining balance (income - expense)</returns>
    public static double CalculateRemaining(double income, double expense)
    {
        double result = income - expense;
        return result;
    }
}