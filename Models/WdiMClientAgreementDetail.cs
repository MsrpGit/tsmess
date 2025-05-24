using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMClientAgreementDetail
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public string TypeOfContract { get; set; } = null!;

    public decimal ContractAmount { get; set; }

    public int NoOfInstallements { get; set; }

    public decimal InstallementAmount { get; set; }

    public decimal SmsunitPrice { get; set; }

    public decimal MailUnitPrice { get; set; }

    public decimal UserUnitPrice { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ReqHashKey { get; set; }

    public string? RespHashKey { get; set; }

    public string? ClientIdForPaytm { get; set; }

    public string Subscribedpgs { get; set; } = null!;
}
