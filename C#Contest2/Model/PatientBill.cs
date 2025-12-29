namespace Contest2
{
    /// <summary>
    /// Represents a patient bill in the MediSure Clinic billing system.
    /// Contains patient information, charges, and calculated amounts including discounts.
    /// Handles automatic bill calculation with insurance discounts.
    /// </summary>
    public class PatientBill
    {
        #region Properties
        /// <summary>
        /// Unique identifier for the bill
        /// </summary>
        public string billNo { get; set; }
        
        /// <summary>
        /// Name of the patient
        /// </summary>
        public string patientName { get; set; }
        
        /// <summary>
        /// Indicates whether the patient has insurance coverage
        /// </summary>
        public bool isInsured { get; set; }
        
        /// <summary>
        /// Fee charged for doctor consultation
        /// </summary>
        public decimal consultFee { get; set; }
        
        /// <summary>
        /// Charges for laboratory tests and procedures
        /// </summary>
        public decimal labCharges { get; set; }
        
        /// <summary>
        /// Charges for medicines and prescriptions
        /// </summary>
        public decimal medicineCharges { get; set; }
        
        /// <summary>
        /// Total amount before any discounts (sum of all charges)
        /// </summary>
        public decimal totalAmount { get; set; }
        
        /// <summary>
        /// Discount amount applied (10% for insured patients)
        /// </summary>
        public decimal discountAmt { get; set; }
        
        /// <summary>
        /// Final amount to be paid after applying discounts
        /// </summary>
        public decimal finalAmount { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor - creates an empty PatientBill object
        /// </summary>
        public PatientBill()
        {
        }

        /// <summary>
        /// Parameterized constructor to create a complete patient bill.
        /// Automatically calculates total, discount, and final amounts.
        /// </summary>
        /// <param name="id">Bill identifier</param>
        /// <param name="name">Patient name</param>
        /// <param name="insurance">Insurance status</param>
        /// <param name="consultation">Consultation fee amount</param>
        /// <param name="lab">Laboratory charges amount</param>
        /// <param name="medicine">Medicine charges amount</param>
        public PatientBill(string id, string name, bool insurance, decimal consultation, decimal lab, decimal medicine)
        {
            billNo = id;
            patientName = name;
            isInsured = insurance;
            consultFee = consultation;
            labCharges = lab;
            medicineCharges = medicine;
            calculateBill(); // Automatically calculate totals and discounts
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates the total bill amount, applies insurance discount if applicable,
        /// and determines the final payable amount.
        /// Insurance provides 10% discount on total amount.
        /// </summary>
        public void calculateBill()
        {
            // Calculate total of all charges
            totalAmount = consultFee + labCharges + medicineCharges;
            
            // Apply 10% discount for insured patients
            if (isInsured)
            {
                discountAmt = totalAmount * 0.10m; // 10% discount
            }
            else
            {
                discountAmt = 0; // No discount for uninsured patients
            }
            
            // Calculate final amount after discount
            finalAmount = totalAmount - discountAmt;
        }
        #endregion
    }
}