namespace tsmess.Models
{
    public  class ImInventoryTransaction
    {
        public int Id { get; set; }

        public string ItemId { get; set; } = null!;

        public int QuantityPresent { get; set; }

        public int VendorId { get; set; }

        public DateTime ReceivedDate { get; set; }

        public int QuantityReceived { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool NoAdulteration { get; set; }

        public bool NoFoulSmell { get; set; }

        public bool NoInsects { get; set; }

        public bool NoTampering { get; set; }

        public bool NotCleanlyPacked { get; set; }

        public string? Remarks { get; set; }

        public bool IsAccepted { get; set; }

        public string ItemType { get; set; } = null!;

        public string PartnerName { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}
