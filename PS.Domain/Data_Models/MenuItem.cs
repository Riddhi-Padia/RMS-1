using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public bool? Type { get; set; }

    public decimal Rate { get; set; }

    public int? Quantity { get; set; }

    public int? UnitId { get; set; }

    public bool? Isavailable { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public decimal? TaxPercentage { get; set; }

    public bool? Isfavourite { get; set; }

    public string? ShortCode { get; set; }

    public bool? Isdefaulttax { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual MenuCategory Category { get; set; } = null!;

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<MappingMenuitemsWithModifier> MappingMenuitemsWithModifiers { get; set; } = new List<MappingMenuitemsWithModifier>();

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Unit? Unit { get; set; }
}
