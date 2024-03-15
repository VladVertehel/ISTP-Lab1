using System;
using System.Collections.Generic;

namespace ShopDomain.Model;

public partial class Order : Entity
{
    public int OrderId { get; set; }

    public DateTime Date { get; set; }

    public int Status { get; set; }

    public int UserId { get; set; }

    public int VinylId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual Vinyl Vinyl { get; set; } = null!;
}
