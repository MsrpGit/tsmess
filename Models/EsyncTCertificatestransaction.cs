using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTCertificatestransaction
{
    public long TransId { get; set; }

    public string UserId { get; set; } = null!;

    public int CertificateId { get; set; }

    public string? CertificateNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? OtherDetails { get; set; }

    public string? UcuniqueCertificateNumber { get; set; }

    public byte Status { get; set; }

    public byte Reprintable { get; set; }

    public int? NoofPrintedTimes { get; set; }

    public string? FeeCollectedBy { get; set; }

    public string? FeeRefNumber { get; set; }

    public int? FeePaymentStatus { get; set; }

    public DateTime PrintedOn { get; set; }

    public string PrintedBy { get; set; } = null!;

    public DateTime? AuthorisedOn { get; set; }

    public string AuthorisedBy { get; set; } = null!;

    public long PartnerId { get; set; }

    public long Academicyearid { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
