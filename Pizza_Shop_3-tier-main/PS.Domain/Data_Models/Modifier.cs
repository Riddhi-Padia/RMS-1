using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class Modifier
{
    public int Id { get; set; }

    public int ModifierGroupId { get; set; }

    public string Name { get; set; } = null!;

    public int? UnitId { get; set; }

    public decimal Rate { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<MappingOrdereditemsWithModifier> MappingOrdereditemsWithModifiers { get; set; } = new List<MappingOrdereditemsWithModifier>();

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ModifierGroup ModifierGroup { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}
