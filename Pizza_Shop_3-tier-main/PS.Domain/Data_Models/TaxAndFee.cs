using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class TaxAndFee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Type { get; set; }

    public decimal? FlatAmount { get; set; }

    public decimal? Percentage { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdefault { get; set; }

    public decimal? Taxvalue { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<MappingOrdersWithTax> MappingOrdersWithTaxes { get; set; } = new List<MappingOrdersWithTax>();

    public virtual Role? ModifiedByNavigation { get; set; }
}
