using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliFamilyMarrageDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public string FullName { get; set; }

    public int GenderId { get; set; }

    public string MarrageDate { get; set; }

    public DateTime MarrageDateEng { get; set; }

    public int MarrageTimeAge { get; set; }

    public virtual Gender Gender { get; set; }

    public virtual HouseOwnerDetail GharMuli { get; set; }
}
