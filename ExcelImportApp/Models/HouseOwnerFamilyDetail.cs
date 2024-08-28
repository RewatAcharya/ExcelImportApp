using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HouseOwnerFamilyDetail
{
    public int Id { get; set; }

    public int HouseOwnerDetailsId { get; set; }

    public string Name { get; set; }

    public string Dob { get; set; }

    public DateTime? Dobeng { get; set; }

    public bool IsDisability { get; set; }

    public int? EducationLevelId { get; set; }

    public string Job { get; set; }

    public bool? IsChildDarta { get; set; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string Nata { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetails { get; set; }
}
