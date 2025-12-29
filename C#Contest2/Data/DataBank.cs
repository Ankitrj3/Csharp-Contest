namespace Contest2
{
    /// <summary>
    /// Data management class for the MediSure Clinic billing system.
    /// Handles all operations related to patient bills including creation, viewing, and deletion.
    /// Maintains the current bill in memory and provides sample data initialization.
    /// </summary>
    public class DataBank
    {
        #region Properties
        /// <summary>
        /// Instance property to hold the current patient bill
        /// </summary>
        public PatientBill? currentBill { get; set; }
        
        /// <summary>
        /// Flag indicating whether a bill currently exists in the system
        /// </summary>
        public bool billExists { get; set; } = false;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor - initializes the DataBank with sample data.
        /// Creates a default bill for demonstration purposes.
        /// </summary>
        public DataBank()
        {
            // Initialize with sample data for testing/demonstration
            currentBill = new PatientBill("BILL1001", "Divya", true, 600.00, 250.00, 150.00);
            billExists = true;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Creates a new patient bill by collecting user input.
        /// Validates all inputs and calculates the bill automatically.
        /// Replaces any existing bill with the new one.
        /// </summary>
        public void addNewBill()
        {
            // Collect bill ID with validation
            Console.WriteLine("Enter Bill Id:");
            string billNo = Console.ReadLine()?.Trim() ?? "";
            
            if (string.IsNullOrEmpty(billNo))
            {
                Console.WriteLine("Bill ID cannot be empty. Please try again.");
                return;
            }

            // Collect patient name
            Console.WriteLine("Enter Patient Name:");
            string name = Console.ReadLine()?.Trim() ?? "";

            // Collect insurance status (Y/N input)
            Console.WriteLine("Is the patient insured? (Y/N):");
            string insured = Console.ReadLine()?.Trim().ToUpper() ?? "";
            bool insurance = insured == "Y"; // Convert Y to true, anything else to false

            // Collect and validate consultation fee
            Console.WriteLine("Enter Consultation Fee:");
            if (!double.TryParse(Console.ReadLine(), out double consultFee) || consultFee <= 0)
            {
                Console.WriteLine("Consultation Fee must be greater than 0. Please try again.");
                return;
            }

            // Collect and validate lab charges
            Console.WriteLine("Enter Lab Charges:");
            if (!double.TryParse(Console.ReadLine(), out double labFee) || labFee < 0)
            {
                Console.WriteLine("Lab Charges must be 0 or greater. Please try again.");
                return;
            }

            // Collect and validate medicine charges
            Console.WriteLine("Enter Medicine Charges:");
            if (!double.TryParse(Console.ReadLine(), out double medFee) || medFee < 0)
            {
                Console.WriteLine("Medicine Charges must be 0 or greater. Please try again.");
                return;
            }

            // Create new bill with validated inputs
            currentBill = new PatientBill(billNo, name, insurance, consultFee, labFee, medFee);
            billExists = true;

            // Display success message with calculated amounts
            Console.WriteLine("Bill created successfully.");
            Console.WriteLine($"Gross Amount: {currentBill.totalAmount:F2}");
            Console.WriteLine($"Discount Amount: {currentBill.discountAmt:F2}");
            Console.WriteLine($"Final Payable: {currentBill.finalAmount:F2}");
        }

        /// <summary>
        /// Displays the details of the current patient bill.
        /// Shows all bill information in a formatted layout.
        /// Checks if a bill exists before displaying.
        /// </summary>
        public void showBill()
        {
            // Check if any bill exists
            if (!billExists || currentBill == null)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            // Display formatted bill details
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine($"BillId: {currentBill.billNo}");
            Console.WriteLine($"Patient: {currentBill.patientName}");
            Console.WriteLine($"Insured: {(currentBill.isInsured ? "Yes" : "No")}");
            Console.WriteLine($"Consultation Fee: {currentBill.consultFee:F2}");
            Console.WriteLine($"Lab Charges: {currentBill.labCharges:F2}");
            Console.WriteLine($"Medicine Charges: {currentBill.medicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {currentBill.totalAmount:F2}");
            Console.WriteLine($"Discount Amount: {currentBill.discountAmt:F2}");
            Console.WriteLine($"Final Payable: {currentBill.finalAmount:F2}");
            Console.WriteLine("--------------------------------");
        }

        /// <summary>
        /// Deletes/clears the current patient bill from memory.
        /// Resets both the bill object and the existence flag.
        /// </summary>
        public void deleteBill()
        {
            currentBill = null; // Clear the current bill
            billExists = false; // Update existence flag
            Console.WriteLine("Last bill cleared.");
        }
        #endregion
    }
}