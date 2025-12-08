using System;
using System.Collections.Generic;

namespace RestaurantApi.Models;

public partial class Rendele
{
    public int Id { get; set; }

    public int? Asztalszam { get; set; }

    public string? Fizetesimod { get; set; }

    public virtual ICollection<Kapcsolo> Kapcsolos { get; set; } = new List<Kapcsolo>();
}
