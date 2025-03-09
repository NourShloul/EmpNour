using System;
using System.Collections.Generic;

namespace EmpNour.Models;

public partial class Salary
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int SalaryAmount { get; set; }

    public virtual User? User { get; set; }
}
