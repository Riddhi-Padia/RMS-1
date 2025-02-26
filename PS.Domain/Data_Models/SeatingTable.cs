using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class SeatingTable
{
    public int Id { get; set; }

    public int SectionId { get; set; }

    public string Name { get; set; } = null!;

    public int? Capacity { get; set; }

    public bool? Isavailable { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<MappingOrdersWithTable> MappingOrdersWithTables { get; set; } = new List<MappingOrdersWithTable>();

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Section Section { get; set; } = null!;

    public virtual ICollection<WaitingToken> WaitingTokens { get; set; } = new List<WaitingToken>();
}
