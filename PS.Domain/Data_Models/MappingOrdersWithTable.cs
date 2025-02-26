using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class MappingOrdersWithTable
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int TableId { get; set; }

    public int Noofperson { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual SeatingTable Table { get; set; } = null!;
}
