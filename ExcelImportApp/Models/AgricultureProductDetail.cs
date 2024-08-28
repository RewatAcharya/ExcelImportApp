using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class AgricultureProductDetail
{
    public int Id { get; set; }

    public int? AgricultureDetailId { get; set; }

    public string BaliKoName { get; set; }

    public string Pariman { get; set; }

    public virtual AgricultureDetail AgricultureDetail { get; set; }
}
