namespace Contest2
{
    public class PatientBill
    {
        // Attributes Declaration
        public string billNo { get; set; }
        public string patientName { get; set; }
        public bool isInsured { get; set; }
        public decimal consultFee { get; set; }
        public decimal labCharges { get; set; }
        public decimal medicineCharges { get; set; }
        public decimal totalAmount { get; set; }
        public decimal discountAmt { get; set; }
        public decimal finalAmount { get; set; }

        // Default Constructor
        public PatientBill()
        {
        }

        // Constructor
        public PatientBill(string id, string name, bool insurance, 
                          decimal consultation, decimal lab, decimal medicine)
        {
            billNo = id;
            patientName = name;
            isInsured = insurance;
            consultFee = consultation;
            labCharges = lab;
            medicineCharges = medicine;
            calculateBill();
        }

        // Function of CalculateBill
        public void calculateBill()
        {
            totalAmount = consultFee + labCharges + medicineCharges;
            
            if (isInsured)
            {
                discountAmt = totalAmount * 0.10m;
            }
            else
            {
                discountAmt = 0;
            }
            
            finalAmount = totalAmount - discountAmt;
        }
    }
}