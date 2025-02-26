using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int RoleId { get; set; }

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Username { get; set; } = null!;

    public long Phone { get; set; }

    public string? Profileimage { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public long? Zipcode { get; set; }

    public string? Address { get; set; }

    public bool? Isactive { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsFirstLogin { get; set; }

    public string Password { get; set; } = null!;

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual State? State { get; set; }
}
