namespace tsmess.Models
{
    public class ItemExpiryModel
    {
        public int TransactionId { get; set; }
        public string Category { get; set; }
        public string ItemName { get; set; }
        public int DaysToExpiry { get; set; }
    }
}
