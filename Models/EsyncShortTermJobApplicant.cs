using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncShortTermJobApplicant
{
    public long Id { get; set; }

    public string? CandidateId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AdvertisementNo { get; set; } = null!;

    public string JobPostingName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifedDate { get; set; }
}
