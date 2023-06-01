using System;
using System.Collections.Generic;

namespace dofaMarketForm.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public int CategoryId { get; set; }

    public decimal UnitPrice { get; set; }

    public short UintsInStock { get; set; }

    public string Supplier { get; set; }

    public virtual Category Category { get; set; }
}
