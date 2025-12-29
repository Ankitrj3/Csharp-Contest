namespace Contest2
{
    /// <summary>
    /// Coding Assessment — MediSure Clinic: Simple Patient Billing 
    /// Main entry point for the MediSure Clinic billing application.
    /// Provides a menu-driven interface for managing patient bills.
    /// </summary>
    class Program
    {
        #region Main Entry Point
        /// <summary>
        /// Main method - entry point of the MediSure Clinic billing application.
        /// Displays menu options and handles user interactions in a loop.
        /// </summary>
        /// <param name="args">Command line arguments (not used)</param>
        public static void Main(string[] args)
        {
            // Create an instance of DataBank to handle billing operations
            DataBank dataBank = new DataBank();
            bool isRunning = true; // Flag to control the main application loop
            
            // Main application loop - continues until user chooses to exit
            while (isRunning)
            {
                displayMenu(); // Show menu options to user
                string option = Console.ReadLine()?.Trim() ?? ""; // Get user input with null safety
                
                // Process user selection using switch statement
                switch (option)
                {
                    case "1":
                        dataBank.addNewBill(); // Create a new patient bill
                        break;
                    case "2":
                        dataBank.showBill(); // Display the current bill
                        break;
                    case "3":
                        dataBank.deleteBill(); // Clear/delete the current bill
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        isRunning = false; // Exit the application
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option (1-4).");
                        break;
                }
                
                // Add separator line between menu iterations (except when exiting)
                if (isRunning)
                {
                    Console.WriteLine("------------------------------------------------------------");
                }
            }
        }
        #endregion
        
        #region Helper Methods
        /// <summary>
        /// Displays the main menu options for the MediSure Clinic billing system.
        /// Shows a formatted menu with all available operations.
        /// </summary>
        static void displayMenu()
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option:");
        }
        #endregion
    }
}
