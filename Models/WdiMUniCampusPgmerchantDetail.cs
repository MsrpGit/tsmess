using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMUniCampusPgmerchantDetail
{
    public long UniCampusMerchantId { get; set; }

    public string MerchantId { get; set; } = null!;

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public long? BankId { get; set; }

    public string PaymentGatewayType { get; set; } = null!;

    public string? PaymentGatewayFields { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
