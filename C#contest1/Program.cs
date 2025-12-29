namespace FirstContest
{
    /// <summary>
    /// Main entry point for the QuickMart Traders Profit Calculator application.
    /// This program allows users to create sales transactions and calculate profit/loss.
    /// </summary>
    class Program
    {
        #region Main Entry Point
        /// <summary>
        /// Main method - entry point of the application.
        /// Creates a DataBank instance and starts the sales transaction menu.
        /// </summary>
        public static void Main()
        {
            // Create an instance of DataBank to handle sales operations
            DataBank db = new DataBank();
            // Start the interactive sales menu
            db.Sale();
        }
        #endregion
    }
}