using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long DepartmentId { get; set; }

    public long DesignationId { get; set; }

    public long? WardId { get; set; }

    public string Phone { get; set; }

    public string Photo { get; set; }

    public string Address { get; set; }

    public long LocalLevelId { get; set; }

    public bool IsActive { get; set; }

    public virtual Department Department { get; set; }

    public virtual Designation Designation { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual Ward Ward { get; set; }
}
