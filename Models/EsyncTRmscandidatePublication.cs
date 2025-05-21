using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidatePublication
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? PublicationType { get; set; }

    public string? Publication { get; set; }

    public string? IndexNational { get; set; }

    public string? IndexInternational { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? PublicationUrl { get; set; }

    public string? PublicationWebsite { get; set; }

    public string? TextBookName { get; set; }

    public string? EditedTextBookName { get; set; }

    public string? ChaptersInBooks { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
