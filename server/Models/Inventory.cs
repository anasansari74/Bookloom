namespace Server.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; } // Navigation property
    }
}
