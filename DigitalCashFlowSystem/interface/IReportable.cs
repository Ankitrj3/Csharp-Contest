
/// <summary>
/// Interface defining the contract for objects that can generate summary reports
/// Used by transaction classes to provide formatted output capabilities
/// </summary>
public interface IReportable
{
    /// <summary>
    /// Generates a summary string representation of the implementing object
    /// </summary>
    ///  /// <returns>Formatted string containing key information about the object</returns>
    string GetSummary();
}
