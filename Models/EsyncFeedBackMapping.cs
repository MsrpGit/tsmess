using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncFeedBackMapping
{
    public long FbmappingId { get; set; }

    public long SubjectId { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public long FbqueryId { get; set; }

    public short RatingScaleValue { get; set; }

    public long AcademicYearId { get; set; }

    public long CampaignId { get; set; }
}
