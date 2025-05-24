using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMealMenuConfiguration2
{
    public long MealiteamId { get; set; }

    public string MealitemName { get; set; } = null!;

    public string? Mealtype { get; set; }

    public int? MealQtyperstudent { get; set; }

    public decimal? TotalMealQtyAllotted { get; set; }

    public decimal? TotalConsumedMealQty { get; set; }

    public decimal? TotalMealQtyAvailable { get; set; }

    public DateTime? Createddate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
