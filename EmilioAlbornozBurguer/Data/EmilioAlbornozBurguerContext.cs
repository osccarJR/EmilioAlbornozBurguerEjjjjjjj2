using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmilioAlbornozBurguer.Models;

namespace EmilioAlbornozBurguer.Data
{
    public class EmilioAlbornozBurguerContext : DbContext
    {
        public EmilioAlbornozBurguerContext (DbContextOptions<EmilioAlbornozBurguerContext> options)
            : base(options)
        {
        }

        public DbSet<EmilioAlbornozBurguer.Models.Burger> Burger { get; set; } = default!;
        public DbSet<EmilioAlbornozBurguer.Models.Promo> Promo { get; set; } = default!;

    }
}
