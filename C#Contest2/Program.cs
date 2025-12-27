namespace Contest2
{
    // <Summary>
    // Coding Assessment — MediSure Clinic: Simple Patient Billing 
    // </Summary>
    class Program
    {
        // Main Function 
        public static void Main(string[] args)
        {
            bool isRunning = true;
            
            while (isRunning)
            {
                displayMenu();
                string option = Console.ReadLine()?.Trim() ?? "";
                // Switch Statement for choosing options
                switch (option)
                {
                    case "1":
                        DataBank.addNewBill();
                        break;
                    case "2":
                        DataBank.showBill();
                        break;
                    case "3":
                        DataBank.deleteBill();
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option (1-4).");
                        break;
                }
                
                if (isRunning)
                {
                    Console.WriteLine("------------------------------------------------------------");
                }
            }
        }
        // Display Function
        static void displayMenu()
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option:");
        }
    }
}
