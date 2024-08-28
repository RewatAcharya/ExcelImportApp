using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class IndustryDetail
{
    public int Id { get; set; }

    public int InstitutionId { get; set; }

    public int Total { get; set; }

    public int WardNo { get; set; }
}
