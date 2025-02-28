using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace PS.Domain.View_Models;

public partial class UserProfile
{
    [Required (ErrorMessage = "Invalid Email")]
    public string Email { get; set; } = null!;

    public int RoleID { get; set; }
    public string Role { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Username { get; set; } = null!;

    public long Phone { get; set; }

    public string? Profileimage { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public long? Zipcode { get; set; }

    public string? Address { get; set; }

    public string Password { get; set; } = null!;

    public bool Isactive { get; set; }

    public bool IsDeleted { get; set; }
}
