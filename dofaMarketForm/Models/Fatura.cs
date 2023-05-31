using System;
using System.Collections.Generic;

namespace dofaMarketForm.Models;

public partial class Fatura
{
    public int Id { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? VerilenPara { get; set; }

    public decimal? PUstu { get; set; }
}
