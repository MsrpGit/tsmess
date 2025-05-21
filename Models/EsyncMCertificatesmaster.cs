using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMCertificatesmaster
{
    public int CertificateId { get; set; }

    public string CertificateName { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public string? Columns { get; set; }

    public string? Datatypes { get; set; }

    public byte Reprintable { get; set; }

    public long PartnerId { get; set; }

    public long Academicyearid { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
