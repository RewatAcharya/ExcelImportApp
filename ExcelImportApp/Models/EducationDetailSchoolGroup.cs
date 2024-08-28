using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class EducationDetailSchoolGroup
{
    public int Id { get; set; }

    public int SchoolLayerId { get; set; }

    public int SchoolTimeId { get; set; }

    public int EducationId { get; set; }

    public virtual EducationDetail Education { get; set; }

    public virtual SchoolLayer SchoolLayer { get; set; }

    public virtual SchoolTime SchoolTime { get; set; }
}
