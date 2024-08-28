﻿using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class SkillType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HouseOwnerDetail> HouseOwnerDetails { get; set; } = new List<HouseOwnerDetail>();
}