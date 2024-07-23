namespace Server.DataModels
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; } // Navigation property
    }
}
