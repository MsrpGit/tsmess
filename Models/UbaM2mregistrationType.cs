using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaM2mregistrationType
{
    public long M2mregTypeId { get; set; }

    public string? Name { get; set; }

    public long? PartnerId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsFullPayment { get; set; }
}
