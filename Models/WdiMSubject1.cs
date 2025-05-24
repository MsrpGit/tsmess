using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSubject1
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public string? Type { get; set; }

    public long? PartnerId { get; set; }

    public bool IsLanguage { get; set; }

    public string? OptingSections { get; set; }

    public bool? Elective { get; set; }

    public int? SequenceNo { get; set; }

    public int? PassPercentage { get; set; }

    public bool? SecondLanguage { get; set; }

    public string? ElectiveCode { get; set; }

    public int? PassPercentageExt { get; set; }

    public byte LanguageType { get; set; }
}
