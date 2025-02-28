using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using PS.Domain.Data_Models;

namespace PS.Domain.View_Models;

public partial class Login
{
    public int Id { get; set; }

    [Required (ErrorMessage = "Invalid Email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;

    
}