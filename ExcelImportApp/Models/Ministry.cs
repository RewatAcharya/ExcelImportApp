using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Ministry
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string ContactNumber { get; set; }

    public string GovermentType { get; set; }

    public string MinisterName { get; set; }

    public string MinisterEmail { get; set; }

    public string MinisterPhoto { get; set; }

    public string PartyName { get; set; }

    public string StartDate { get; set; }

    public long StateId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual State State { get; set; }
}
