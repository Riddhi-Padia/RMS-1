using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class MappingOrdereditemsWithModifier
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public int ModifierId { get; set; }

    public int? Quantityofmodifier { get; set; }

    public decimal? Rateofmodifier { get; set; }

    public decimal? Totalamount { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Modifier Modifier { get; set; } = null!;

    public virtual OrderItem OrderItem { get; set; } = null!;
}
