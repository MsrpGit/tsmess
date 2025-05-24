using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLibraryissuereturn1
{
    public long Lirid { get; set; }

    public string UserId { get; set; } = null!;

    public long AccessionId { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public long PartnerId { get; set; }

    public bool Active { get; set; }

    /// <summary>
    /// If Book Type is ::  1 -- Normal Book ; 0 -- BookBank Book
    /// </summary>
    public int? BookType { get; set; }
}
