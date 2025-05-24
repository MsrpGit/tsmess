using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMealMenuConfigurationTransactionDetail2
{
    public int Id { get; set; }

    public long? MealiteamId { get; set; }

    public decimal? TotalMealQtyAllotted { get; set; }

    public DateTime? Createddate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
