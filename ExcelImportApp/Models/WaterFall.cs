﻿using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class WaterFall
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Height { get; set; }

    public string Address { get; set; }

    public string Description { get; set; }

    public string Photo { get; set; }

    public long? WardId { get; set; }

    public long LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? DistrictId { get; set; }

    public long? StateId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual Ward Ward { get; set; }
}
