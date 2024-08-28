using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HouseOwnerAbdhiGroup
{
    public int Id { get; set; }

    public int AbhadhiId { get; set; }

    public int HouseOwnerId { get; set; }

    public int Count { get; set; }

    public virtual Abhadhi Abhadhi { get; set; }

    public virtual HouseOwnerDetail HouseOwner { get; set; }
}
