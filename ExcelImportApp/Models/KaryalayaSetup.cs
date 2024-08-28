using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class KaryalayaSetup
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public long ProvinceId { get; set; }

    public long DistrictId { get; set; }

    public long PalikaId { get; set; }

    public string Email { get; set; }

    public string Contact { get; set; }

    public int Wardno { get; set; }

    public virtual District District { get; set; }

    public virtual LocalLevel Palika { get; set; }

    public virtual State Province { get; set; }
}
