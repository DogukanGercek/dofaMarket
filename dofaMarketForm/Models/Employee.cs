using System;
using System.Collections.Generic;

namespace dofaMarketForm.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Title { get; set; }

    public DateTime? BirthDate { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? HireDate { get; set; }

    public int? Tel { get; set; }
}
