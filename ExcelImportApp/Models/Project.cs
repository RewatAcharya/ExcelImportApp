using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Project
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Status { get; set; }

    public string StartDate { get; set; }

    public string AcceptedDate { get; set; }

    public string CompletionDate { get; set; }

    public string Budget { get; set; }

    public string BenefitFamilyNo { get; set; }

    public string CommitteeName { get; set; }

    public string CommitteeHeadName { get; set; }

    public string CommitteeHeadPhoneNo { get; set; }

    public string PercentageOfWorkDone { get; set; }

    public string ThekdarName { get; set; }

    public string ThekdarPhoneNo { get; set; }

    public long? WardId { get; set; }

    public long LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual Ward Ward { get; set; }
}
