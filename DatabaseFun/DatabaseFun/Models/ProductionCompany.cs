using System;
using System.Collections.Generic;

namespace DatabaseFun.Models;

public partial class ProductionCompany
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
