/// <summary>
/// Represents an income transaction in the cash flow system
/// Inherits from Transaction base class and adds income-specific properties
/// </summary>
public class IncomeTransaction : Transaction
{
    /// <summary>
    /// Gets or sets the source of the income (e.g., Salary, Freelance, Investment)
    /// </summary>
    public string? Source { get; set; }

    /// <summary>
    /// Generates a formatted summary string for the income transaction
    /// </summary>
    /// <returns>Formatted string containing income details including source</returns>
    public override string GetSummary()
    {
        return $"[INCOME] Id: {Id}, Date: {Date.ToShortDateString()}, Amount: ${Amount}, Source: {Source}, Description: {Description}";
    }
}
