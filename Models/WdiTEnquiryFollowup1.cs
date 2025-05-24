using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEnquiryFollowup1
{
    public long FollowupId { get; set; }

    public long? EnquiryId { get; set; }

    public DateOnly? Date { get; set; }

    public string? FollowupType { get; set; }

    public string? FollowupDetails { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? Fupby { get; set; }

    public string? Fupmode { get; set; }

    public string? Fupremarks { get; set; }

    public DateOnly? Fupretdate { get; set; }

    public string? Fupemailid { get; set; }

    public string? Fupmobileno { get; set; }
}
