using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Designation
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? DepartmentId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Department Department { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
