using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Department
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Designation> Designations { get; set; } = new List<Designation>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
