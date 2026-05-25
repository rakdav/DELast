using System;
using System.Collections.Generic;

namespace DE.Models;

public partial class Product
{
    public string Articul { get; set; } = null!;

    public string NameTovar { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public string Suplier { get; set; } = null!;

    public string Manufactor { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int Discount { get; set; }

    public int Quantity { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
