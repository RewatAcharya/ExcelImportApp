using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HealthDetail
{
    public int Id { get; set; }

    public int? WardNo { get; set; }

    public bool IsChronicDiseases { get; set; }

    public bool IsDisabilityFamily { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public bool? SchoolC23 { get; set; }

    public string UpacharWhere { get; set; }

    public virtual ICollection<HealthDetailChronicDiseaseGroup> HealthDetailChronicDiseaseGroups { get; set; } = new List<HealthDetailChronicDiseaseGroup>();

    public virtual ICollection<HealthDetailDisabilityCardGroup> HealthDetailDisabilityCardGroups { get; set; } = new List<HealthDetailDisabilityCardGroup>();

    public virtual ICollection<HealthDetailDisabilityReasonGroup> HealthDetailDisabilityReasonGroups { get; set; } = new List<HealthDetailDisabilityReasonGroup>();

    public virtual ICollection<HealthDetailDisabilityTypeGroup> HealthDetailDisabilityTypeGroups { get; set; } = new List<HealthDetailDisabilityTypeGroup>();

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }
}
