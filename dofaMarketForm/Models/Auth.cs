using System;
using System.Collections.Generic;

namespace dofaMarketForm.Models;

public partial class Auth
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }
}
