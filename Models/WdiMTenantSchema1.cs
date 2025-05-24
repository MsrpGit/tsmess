using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTenantSchema1
{
    public long TenantSchemaId { get; set; }

    public string SchemaName { get; set; } = null!;

    public string SchemaUserId { get; set; } = null!;

    /// <summary>
    /// Shema Key Means saving the Password of Schema.
    /// </summary>
    public string SchemaKey { get; set; } = null!;

    public string SchemaDataBase { get; set; } = null!;

    public string SchemaServer { get; set; } = null!;

    public long PartnerId { get; set; }

    public string UserId { get; set; } = null!;

    public string SchemaCreatedBy { get; set; } = null!;

    public DateTime SchemaCreatedDate { get; set; }

    public string? SchemaModifiedBy { get; set; }

    public DateTime? SchemaModifiedDate { get; set; }

    /// <summary>
    /// DefaultValue - Initiated , Created - Created, Updated - Updated, Deleted - Deleted , archived - archived
    /// </summary>
    public string SchemaStatus { get; set; } = null!;

    public string? CommunitySchemaName { get; set; }

    public string? CommunitySchemaUserId { get; set; }

    public string? CommunitySchemaKey { get; set; }

    public string? CommunitySchemaDataBase { get; set; }

    public string? CommunitySchemaServer { get; set; }
}
