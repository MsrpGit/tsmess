using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLibraryaccession
{
    public long AccessionId { get; set; }

    public string AccessionNo { get; set; } = null!;

    public string BookCode { get; set; } = null!;

    public int Quantity { get; set; }

    public long? ItemId { get; set; }

    public long? CategoryId { get; set; }

    public string? Author { get; set; }

    public string? Title { get; set; }

    public string? BookEdition { get; set; }

    public string? YearOfPub { get; set; }

    public int? Pages { get; set; }

    public string? Isbnnum { get; set; }

    public decimal? Cost { get; set; }

    public string? BillNum { get; set; }

    public DateTime? BillDate { get; set; }

    public long? RackId { get; set; }

    public string? Slot { get; set; }

    public long? PublisherId { get; set; }

    public long? SupplierId { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public long PartnerId { get; set; }

    /// <summary>
    /// Here By default 1 -- means Book Added. ;  0- Means Deleted Book.
    /// </summary>
    public bool Active { get; set; }

    public int SubjectId { get; set; }

    public int ClassId { get; set; }
}
