using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerWeb.Models;

namespace SoccerWeb.Data
{
    public class SoccerWebContext : DbContext
    {
        public SoccerWebContext (DbContextOptions<SoccerWebContext> options)
            : base(options)
        {
        }

        public DbSet<SoccerWeb.Models.Club> Club { get; set; } = default!;
        public DbSet<SoccerWeb.Models.Jugador> Jugador { get; set; } = default!;
    }
}


