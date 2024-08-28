using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class ArthikBarsaSetup
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateOnly BeginningYear { get; set; }

    public DateOnly EndingYear { get; set; }

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    public bool State { get; set; }
}
