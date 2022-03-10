using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante.Models;

namespace Restaurante.Models
{
    public class RestauranteContext:DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        {
        }
        
        public DbSet<Registo> Registo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
    }

}
