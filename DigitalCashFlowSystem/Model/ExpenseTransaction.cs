/// <summary>
/// Represents an expense transaction in the cash flow system
/// Inherits from Transaction base class and adds expense-specific properties
/// </summary>
public class ExpenseTransaction : Transaction
{
    /// <summary>
    /// Gets or sets the category of the expense (e.g., Rent, Groceries, Utilities)
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Generates a formatted summary string for the expense transaction
    /// </summary>
    /// <returns>Formatted string containing expense details including category</returns>
    public override string GetSummary()
    {
        return $"[EXPENSE] Id: {Id}, Date: {Date.ToShortDateString()}, Amount: ${Amount}, Category: {Category}, Description: {Description}";
    }
}
