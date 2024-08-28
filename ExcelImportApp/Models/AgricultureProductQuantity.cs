using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class AgricultureProductQuantity
{
    public int Id { get; set; }

    public int? AgricultureDetailId { get; set; }

    public string Milk { get; set; }

    public string Meat { get; set; }

    public string Egg { get; set; }

    public string Bone { get; set; }

    public string Skin { get; set; }

    public string Wool { get; set; }

    public string Other { get; set; }

    public virtual AgricultureDetail AgricultureDetail { get; set; }
}
