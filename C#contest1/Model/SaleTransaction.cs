namespace FirstContest
{
    /// <summary>
    /// Coding Assessment — QuickMart Traders: Profit Calculator
    /// Represents a sales transaction with purchase and selling details.
    /// Used to calculate profit/loss for individual transactions.
    /// </summary>
    class SaleTransaction
    {
        #region Properties
        /// <summary>
        /// Unique identifier for the invoice/transaction
        /// </summary>
        public string? invoiceId{get; set;}
        
        /// <summary>
        /// Name of the customer making the purchase
        /// </summary>
        public string? customerName{get; set;}
        
        /// <summary>
        /// Name of the item being sold
        /// </summary>
        public string? itemName{get; set;}
        
        /// <summary>
        /// Quantity of items sold in this transaction
        /// </summary>
        public int qty{get; set;}
        
        /// <summary>
        /// Purchase price per unit 
        /// </summary>
        public float buyPrice{get; set;}
        
        /// <summary>
        /// Selling price per unit 
        /// </summary>
        public float sellPrice{get; set;}
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor - initializes empty SaleTransaction object
        /// </summary>
        public SaleTransaction()
        {
            
        }

        /// <summary>
        /// Parameterized constructor to create a complete sales transaction
        /// </summary>
        /// <param name="invoice">Invoice ID for the transaction</param>
        /// <param name="customer">Customer name</param>
        /// <param name="item">Item name being sold</param>
        /// <param name="quantity">Quantity of items</param>
        /// <param name="purchase">Purchase price per unit</param>
        /// <param name="selling">Selling price per unit</param>
        public SaleTransaction(string invoice, string customer, string item, int quantity, float purchase, float selling)
        {
            invoiceId = invoice;
            customerName = customer;
            itemName = item;
            qty = quantity;
            buyPrice = purchase;
            sellPrice = selling;
        }
        #endregion
    }
}