using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTodolist2
{
    public int Id { get; set; }

    public string Item { get; set; } = null!;

    /// <summary>
    /// category either     Personal /  Official
    /// </summary>
    public string Category { get; set; } = null!;

    /// <summary>
    /// Pending  ; Completed 
    /// </summary>
    public string Status { get; set; } = null!;

    public DateTime Date { get; set; }

    public string UserId { get; set; } = null!;
}
