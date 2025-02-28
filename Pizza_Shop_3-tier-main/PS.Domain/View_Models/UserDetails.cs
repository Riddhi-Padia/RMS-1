using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace PS.Domain.View_Models;

public partial class UserDetails
{
    [Required (ErrorMessage = "Invalid Email")]
    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Username { get; set; } = null!;

    public long Phone { get; set; }

    public string? Profileimage { get; set; }

    public bool Isactive { get; set; }

    public bool IsDeleted { get; set; }
}