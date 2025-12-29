namespace FirstContest
{
    /// <summary>
    /// DataBank class handles all sales transaction operations for QuickMart Traders.
    /// Provides functionality to create, view, and calculate profit/loss for sales transactions.
    /// Maintains the last transaction in memory for quick access.
    /// </summary>
    class DataBank
    {
        #region Fields
        /// <summary>
        /// Field to store the most recent sales transaction
        /// </summary>
        private SaleTransaction? lastSale;
        #endregion

        #region Public Methods
        /// <summary>
        /// Main menu method that displays options and handles user interaction.
        /// Provides a loop-based menu system for transaction management.
        /// </summary>
        public void Sale() // Sale is void function which will print the results
        {
            int choice; // Variable to store user's menu choice
            
            // Main application loop - continues until user chooses to exit
            do
            {
                // Display menu options to the user
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                
                // Get user input and validate it's a number
                string? input = Console.ReadLine();
                // Type Conversion string -> int with validation
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue; // Skip to next iteration if invalid input
                }

                // Process user choice using switch statement
                switch (choice)
                {
                    case 1:
                        AddTransaction(); // Create new transaction
                        break;
                    case 2:
                        ViewTransaction(); // Display last transaction
                        break;
                    case 3:
                        CalculateProfit(); // Calculate and show profit/loss
                        break;
                    case 4:
                        Console.WriteLine("Exiting..."); // Exit application
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4); // Continue until user chooses exit (4)
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Creates a new sales transaction by collecting user input.
        /// Validates all inputs and creates a SaleTransaction object.
        /// Stores the transaction as the current lastSale.
        /// </summary>
        private void AddTransaction()
        {
            // Collect transaction details from user input
            Console.WriteLine("Enter Invoice No");
            string? invoiceNo = Console.ReadLine();
            Console.WriteLine("Enter Customer Name");
            string? custName = Console.ReadLine();
            Console.WriteLine("Enter Item Name");
            string? product = Console.ReadLine();
            Console.WriteLine("Enter Item Quantity");
            string? quantity = Console.ReadLine();
            Console.WriteLine("Enter Purchase Amount");
            string? buyAmt = Console.ReadLine();
            Console.WriteLine("Enter Selling Amount");
            string? sellAmt = Console.ReadLine();

            // Validate that all required fields are provided
            if (string.IsNullOrEmpty(invoiceNo) || string.IsNullOrEmpty(custName) || 
                string.IsNullOrEmpty(product) || string.IsNullOrEmpty(quantity) || 
                string.IsNullOrEmpty(buyAmt) || string.IsNullOrEmpty(sellAmt))
            {
                Console.WriteLine("All fields are required. Transaction not created.");
                return;
            }

            // Parse and validate numeric inputs
            if (!int.TryParse(quantity, out int qty) || 
                !float.TryParse(buyAmt, out float purchasePrice) || 
                !float.TryParse(sellAmt, out float sellingPrice))
            {
                Console.WriteLine("Invalid numeric input. Transaction not created.");
                return;
            }

            // Create new transaction object and store it
            lastSale = new SaleTransaction(invoiceNo, custName, product, qty, purchasePrice, sellingPrice);
            Console.WriteLine("Transaction created successfully!");
        }

        /// <summary>
        /// Displays the details of the last created transaction.
        /// Shows all transaction fields in a formatted manner.
        /// </summary>
        private void ViewTransaction()
        {
            // Check if any transaction exists
            if (lastSale == null)
            {
                Console.WriteLine("No transaction found. Please create a transaction first.");
                return;
            }

            // Display all transaction details
            Console.WriteLine("Invoice No: " + lastSale.invoiceId);
            Console.WriteLine("Customer Name: " + lastSale.customerName);
            Console.WriteLine("Item Name: " + lastSale.itemName);
            Console.WriteLine("Item Quantity: " + lastSale.qty);
            Console.WriteLine("Purchase Amount: " + lastSale.buyPrice);
            Console.WriteLine("Selling Amount: " + lastSale.sellPrice);
        }
        
        /// <summary>
        /// Calculates and displays profit/loss information for the last transaction.
        /// Computes profit amount, margin percentage, and status (PROFIT/LOSS/BREAK-EVEN).
        /// </summary>
        private void CalculateProfit()
        {
            // Ensure a transaction exists before calculation
            if (lastSale == null)
            {
                Console.WriteLine("No transaction found. Please create a transaction first.");
                return;
            }

            // Calculate profit/loss amount
            float profitLoss = lastSale.sellPrice - lastSale.buyPrice;
            string status; // Variable to store profit/loss status
            
            // Determine profit/loss status based on amount
            if (profitLoss > 0)
            {
                status = "PROFIT";
            }
            else if (profitLoss < 0)
            {
                status = "LOSS";
            }
            else
            {
                status = "BREAK-EVEN";
            }
            
            // Calculate profit margin as percentage
            float margin = profitLoss / lastSale.buyPrice * 100;
            
            // Display calculated results
            Console.WriteLine("Profit/Loss amount: " + profitLoss);
            Console.WriteLine("ProfitMarginPercent = " + margin);
            Console.WriteLine("ProfitOrLossStatus = " + status);
        }
        #endregion
    }
}
