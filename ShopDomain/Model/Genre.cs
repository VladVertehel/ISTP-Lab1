using System;
using System.Collections.Generic;

namespace ShopDomain.Model;

public partial class Genre : Entity
{
    public int GenreId { get; set; }

    public string Genre1 { get; set; } = null!;

    public virtual ICollection<Vinyl> Vinyls { get; set; } = new List<Vinyl>();
}
