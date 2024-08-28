using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class EducationDetail
{
    public int Id { get; set; }

    public int? WardNo { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public bool? AnyChild5To14GoingtoSchool { get; set; }

    public string StayAddress { get; set; }

    public bool? AnyChild10To19 { get; set; }

    public int? Child10To19Male { get; set; }

    public int? Child10To19Female { get; set; }

    public bool? HaveFeedIronPillsForFemale { get; set; }

    public bool? HaveTenagersFemaleTranningAboutHealth { get; set; }

    public bool? AnyTorturePhysicalAndMental { get; set; }

    public bool? AnyChildHaveNotGoToCollage { get; set; }

    public int? WhereAreTheyNowId { get; set; }

    public bool? AnyVocationalTraning { get; set; }

    public string VocationalTraningName { get; set; }

    public string AnyViolenceOccurredYourChild { get; set; }

    public string RegisterCaseAddress { get; set; }

    public bool? AnyKamalariFemale { get; set; }

    public virtual ICollection<EducationDetailSchoolGroup> EducationDetailSchoolGroups { get; set; } = new List<EducationDetailSchoolGroup>();

    public virtual ICollection<EducationEducationalLevelGroup> EducationEducationalLevelGroups { get; set; } = new List<EducationEducationalLevelGroup>();

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }

    public virtual WhereAreTheyNow WhereAreTheyNow { get; set; }
}
