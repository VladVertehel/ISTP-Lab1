using System;
using System.Collections.Generic;

namespace ShopDomain.Model;

public partial class Author : Entity
{
    public int AuthorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Vinyl> Vinyls { get; set; } = new List<Vinyl>();
}
