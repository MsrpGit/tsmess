using System.ComponentModel.DataAnnotations;

namespace tsmess.Models
{
    public class ImSupplierMasters
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = string.Empty;
    }
}
