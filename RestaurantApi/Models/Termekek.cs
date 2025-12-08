using System;
using System.Collections.Generic;

namespace RestaurantApi.Models;

public partial class Termekek
{
    public int Id { get; set; }

    public string? Etel { get; set; }

    public int? Ar { get; set; }

    public virtual ICollection<Kapcsolo> Kapcsolos { get; set; } = new List<Kapcsolo>();
}
