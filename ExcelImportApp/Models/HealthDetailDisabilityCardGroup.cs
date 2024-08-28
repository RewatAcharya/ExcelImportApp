using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HealthDetailDisabilityCardGroup
{
    public int Id { get; set; }

    public int HealthDetailId { get; set; }

    public int DisabilityCardId { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual DisabilityCard DisabilityCard { get; set; }

    public virtual HealthDetail HealthDetail { get; set; }
}
