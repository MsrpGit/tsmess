using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tsmess.Models
{
    public class VendorMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VendorId { get; set; }

        //[MaxLength(50)]
        //public string? VendorTitle { get; set; }

        //[Required]
        //[MaxLength(50)]
        //public string VendorSurname { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string VendorName { get; set; } = string.Empty;

        //[Required]
        //[MaxLength(50)]
        //public string VendorSupplingAreaDistricts { get; set; } = string.Empty;

        //[Required]
        //[MaxLength(50)]
        //public string VendorSuppliingAreaZones { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string VendorContact { get; set; } = string.Empty;

        //[MaxLength(50)]
        //public string? VendorSecondaryContact { get; set; }

        [Required]
        [MaxLength(50)]
        public string VendorType { get; set; } = string.Empty;

        //[Required]
        //[MaxLength(50)]
        //public string VendorAcType { get; set; } = string.Empty;

        //[Required]
        //[MaxLength(200)]
        //public string VendorLocationCity { get; set; } = string.Empty;

        //[MaxLength(50)]
        //public string? VendorLocationDistrict { get; set; }

        //[MaxLength(50)]
        //public string? VendorLocationZone { get; set; }

        //[Required]
        //[MaxLength(1000)]
        //public string VendorAddress { get; set; } = string.Empty;

        //[Required]
        //[MaxLength(50)]
        //public string VendorPinCode { get; set; } = string.Empty;

        //[MaxLength(50)]
        //public string? VendorTINNumber { get; set; }

        //[MaxLength(50)]
        //public string? VendorPANNumber { get; set; }

        //[MaxLength(50)]
        //public string? VendorGSTNumber { get; set; }

        //[MaxLength(50)]
        //public string? BusinessNature { get; set; }

        //[MaxLength(50)]
        //public string? VendorBankName { get; set; }

        [MaxLength(50)]
        public string? VendorBankAccountNo { get; set; }

        [MaxLength(50)]
        public string? VendorBankIFSC { get; set; }

        //[MaxLength(50)]
        //public string? VendorBankBranch { get; set; }

        //[MaxLength(50)]
        //public string? VendorIDCardNumer { get; set; }

        //[MaxLength(50)]
        //public string? VendorStatus { get; set; }

        public string? CircularUploadPath { get; set; }
        public string? VendorDocsPath { get; set; }

    }
}
