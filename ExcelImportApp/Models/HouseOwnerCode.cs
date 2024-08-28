using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HouseOwnerCode
{
    public int Id { get; set; }

    public long LocalLavelId { get; set; }

    public long WardId { get; set; }

    public int Code { get; set; }

    public int HouseOwnerId { get; set; }

    public virtual HouseOwnerDetail HouseOwner { get; set; }

    public virtual LocalLevel LocalLavel { get; set; }

    public virtual Ward Ward { get; set; }
}
