using AtmInsight.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cajero> Cajeros { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<EstadisticaDiaria> EstadisticaDiarias { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<ConsumoRepuesto> ConsumosRepuestos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
