using System;
using System.Collections.Generic;

namespace EmpNour.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public int NationalNumber { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();
}
