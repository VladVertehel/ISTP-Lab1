using System;
using System.Collections.Generic;

namespace ShopDomain.Model;

public partial class Vinyl : Entity
{
    public int VinylId { get; set; }

    public string Name { get; set; } = null!;

    public int Year { get; set; }

    public int AuthorId { get; set; }

    public int GenreId { get; set; }

    public string Country { get; set; } = null!;

    public virtual Author Author { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
