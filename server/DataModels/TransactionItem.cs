namespace Server.DataModels
{
    public class TransactionItem
    {
        public int TransactionItemId { get; set; }
        public int BookId { get; set; }
        public int TransactionId { get; set; }
        public string BookTitle { get; set; }
        public decimal BookPrice { get; set; }
        public int QuantitySold { get; set; }
        public Book Book { get; set; } // Navigation property
        public Transaction Transaction { get; set; } // Navigation property
    }
}
