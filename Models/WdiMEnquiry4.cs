using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEnquiry4
{
    public long EnquiryId { get; set; }

    public long PartnerId { get; set; }

    public string AdmissionNo { get; set; } = null!;

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public short? Religion { get; set; }

    public short? Caste { get; set; }

    public DateTime? Dob { get; set; }

    public string? EmailId { get; set; }

    public string? Mobile { get; set; }

    public string? ContactNumber { get; set; }

    public string? PresentAddress { get; set; }

    public string? PresentCity { get; set; }

    public short? CountryId { get; set; }

    public string? State { get; set; }

    public long? PresentClass { get; set; }

    public long? AdmissionClass { get; set; }

    public string? Medium { get; set; }

    public short Status { get; set; }

    public DateTime EnquiryDate { get; set; }

    public string EnquiryReason { get; set; } = null!;

    public string? EnquiryPerson { get; set; }

    public long AcademicYearId { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobile { get; set; }

    public byte[]? EncryptedContactNumber { get; set; }
}
