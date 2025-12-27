namespace Contest2
{
    public static class DataBank
    {
        public static PatientBill? currentBill { get; set; }
        public static bool billExists { get; set; } = false;

        static DataBank()
        {
            // Initialize with sample data
            currentBill = new PatientBill("BILL1001", "Divya", true, 600.00m, 250.00m, 150.00m);
            billExists = true;
        }

        public static void addNewBill()
        {
            Console.WriteLine("Enter Bill Id:");
            string billNo = Console.ReadLine()?.Trim() ?? "";
            
            if (string.IsNullOrEmpty(billNo))
            {
                Console.WriteLine("Bill ID cannot be empty. Please try again.");
                return;
            }

            Console.WriteLine("Enter Patient Name:");
            string name = Console.ReadLine()?.Trim() ?? "";

            Console.WriteLine("Is the patient insured? (Y/N):");
            string insured = Console.ReadLine()?.Trim().ToUpper() ?? "";
            bool insurance = insured == "Y";

            Console.WriteLine("Enter Consultation Fee:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal consultFee) || consultFee <= 0)
            {
                Console.WriteLine("Consultation Fee must be greater than 0. Please try again.");
                return;
            }

            Console.WriteLine("Enter Lab Charges:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal labFee) || labFee < 0)
            {
                Console.WriteLine("Lab Charges must be 0 or greater. Please try again.");
                return;
            }

            Console.WriteLine("Enter Medicine Charges:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal medFee) || medFee < 0)
            {
                Console.WriteLine("Medicine Charges must be 0 or greater. Please try again.");
                return;
            }

            currentBill = new PatientBill(billNo, name, insurance, consultFee, labFee, medFee);
            billExists = true;

            Console.WriteLine("Bill created successfully.");
            Console.WriteLine($"Gross Amount: {currentBill.totalAmount:F2}");
            Console.WriteLine($"Discount Amount: {currentBill.discountAmt:F2}");
            Console.WriteLine($"Final Payable: {currentBill.finalAmount:F2}");
        }

        public static void showBill()
        {
            if (!billExists || currentBill == null)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

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

        public static void deleteBill()
        {
            currentBill = null;
            billExists = false;
            Console.WriteLine("Last bill cleared.");
        }
    }
}