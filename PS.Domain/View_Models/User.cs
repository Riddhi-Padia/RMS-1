using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using PS.Domain.Data_Models;

namespace PS.Domain.View_Models;

public partial class User
{
    public int Id { get; set; }

    [Required (ErrorMessage = "Invalid Email")]
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

    public bool Isactive { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsFirstLogin { get; set; } = null!;

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual State? State { get; set; }
}
