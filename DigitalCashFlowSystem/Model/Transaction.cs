using System;

/// <summary>
/// Abstract base class for all financial transactions in the system
/// Implements IReportable interface to provide summary functionality
/// Serves as the foundation for both income and expense transactions
/// </summary>
public abstract class Transaction : IReportable
{
    /// <summary>
    /// Gets or sets the unique identifier for the transaction
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Gets or sets the date when the transaction occurred
    /// </summary>
    public DateOnly Date { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount of the transaction
    /// </summary>
    public double Amount { get; set; }
    
    /// <summary>
    /// Gets or sets a description providing additional details about the transaction
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Abstract method that must be implemented by derived classes
    /// to provide a formatted summary of the transaction
    /// </summary>
    /// <returns>Formatted string representation of the transaction</returns>
    public abstract string GetSummary();
}
