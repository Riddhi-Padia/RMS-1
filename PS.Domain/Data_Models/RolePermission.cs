using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class RolePermission
{
    public int Id { get; set; }

    public int PermissionId { get; set; }

    public int RoleId { get; set; }

    public bool? Canview { get; set; }

    public bool? Canedit { get; set; }

    public bool? Candelete { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
