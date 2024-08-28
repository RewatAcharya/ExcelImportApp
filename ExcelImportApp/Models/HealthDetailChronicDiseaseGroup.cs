using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HealthDetailChronicDiseaseGroup
{
    public int Id { get; set; }

    public int ChronicDiseaseId { get; set; }

    public int HealthDetailIid { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual ChronicDisease ChronicDisease { get; set; }

    public virtual HealthDetail HealthDetailI { get; set; }
}
