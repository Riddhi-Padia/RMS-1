using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int MenuItemId { get; set; }

    public int Quantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Totalmodifieramount { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Totalamount { get; set; }

    public string? Instruction { get; set; }

    public int? Status { get; set; }

    public int? Readyitemquantity { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<MappingOrdereditemsWithModifier> MappingOrdereditemsWithModifiers { get; set; } = new List<MappingOrdereditemsWithModifier>();

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Order Order { get; set; } = null!;
}
