using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTNewLetterSubscription
{
    public long SubscriptionId { get; set; }

    public DateTime? SubsDate { get; set; }

    public string? FullName { get; set; }

    public string? EmailId { get; set; }

    public bool? TermsAccepted { get; set; }

    public DateTime? LastNotified { get; set; }

    public bool? Status { get; set; }
}
