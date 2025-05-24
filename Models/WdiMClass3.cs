using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMClass3
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public long? PartnerId { get; set; }

    /// <summary>
    /// 0: watch2learn classes; -1: partners CLasses; other numbers : mapped to watch2learn classes 
    /// </summary>
    public int W2lClassId { get; set; }

    public int? TotalSeats { get; set; }

    public bool? IsCce { get; set; }

    /// <summary>
    /// Here :: -1 no department Exist.
    /// </summary>
    public long DepartmentId { get; set; }

    public string? ClassCode { get; set; }

    /// <summary>
    /// 1 -- ARTS/COMMERCE/SCIENCE ; 2 -- MPC ; 3 --MPC/MEC ; 4 -- BPC/MPBC ; 5 -- BPC/MPBC/MPC ; 6 -- B.Sc. Maths-Comp Sc ; 7 -- B.Sc. Life Sciences ; 8 -- B.Sc. Mathematics ; 9 -- B.Sc. Chemistry ; 10 -- BA/BCom/BSc/BBA/BMS  ; 11 - B.Com/BSc(MAT/STA/CSC)/BBA/BMS ;
    /// 12 - Othre.
    /// </summary>
    public string? StreamId { get; set; }

    /// <summary>
    /// 1-- Aided ; 0-- UnAided
    /// </summary>
    public bool? IsAided { get; set; }

    /// <summary>
    /// 0-- INTER ; 1 -- CBSE ; 2 -- ISC ; 3 -- BA ; 4 -- BSC ; 5 - BCom ; 6 - BMS ; 7- BBA  ; 8 - Othere.
    /// </summary>
    public long? ExaminationPassed { get; set; }

    public string CoschalsticMarksByTermorExam { get; set; } = null!;

    public int SequenceNo { get; set; }

    public bool IsAttendance { get; set; }

    public string? Remarks { get; set; }
}
