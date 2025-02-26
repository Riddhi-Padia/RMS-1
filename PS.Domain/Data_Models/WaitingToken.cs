using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class WaitingToken
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int NoOfPerson { get; set; }

    public int SectionId { get; set; }

    public int? TableId { get; set; }

    public bool? Isassigned { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual Section Section { get; set; } = null!;

    public virtual SeatingTable? Table { get; set; }
}
