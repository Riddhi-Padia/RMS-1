using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class MappingMenuitemsWithModifier
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }

    public int ModifierGroupId { get; set; }

    public int? MinSelectionRequired { get; set; }

    public int? MaxSelectionAllowed { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ModifierGroup ModifierGroup { get; set; } = null!;
}
