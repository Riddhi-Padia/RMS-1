using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
