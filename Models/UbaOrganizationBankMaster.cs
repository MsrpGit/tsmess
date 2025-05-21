using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaOrganizationBankMaster
{
    public int Id { get; set; }

    public string BankName { get; set; } = null!;

    public string BankAddress { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string Ifsccode { get; set; } = null!;

    public string? SwiftCode { get; set; }

    public long OrganizationId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
