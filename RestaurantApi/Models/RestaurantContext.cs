using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApi.Models;

public partial class RestaurantContext : DbContext
{
    public RestaurantContext(DbContextOptions<RestaurantContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kapcsolo> Kapcsolos { get; set; }

    public virtual DbSet<Rendele> Rendeles { get; set; }

    public virtual DbSet<Termekek> Termekeks { get; set; }
   
}

