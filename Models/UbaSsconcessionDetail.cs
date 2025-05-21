using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaSsconcessionDetail
{
    public int Id { get; set; }

    public long? ClassId { get; set; }

    public long? FeeHeadId { get; set; }

    public long? M2mregTypeId { get; set; }

    public long? SsconcessionId { get; set; }

    public decimal SsconcessionAmountLimit { get; set; }

    public decimal SsconcessionCountLimit { get; set; }

    public decimal SsconcessionPercentageLimit { get; set; }

    public byte SsconcessionStatus { get; set; }

    public decimal TotalConsumed { get; set; }

    public DateTime? VaildFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
