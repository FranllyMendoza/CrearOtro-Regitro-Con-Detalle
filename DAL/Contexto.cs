using CrearOtro_Regitro_Con_Detalle.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtro_Regitro_Con_Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\GestionUsuario.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                    new Permisos() { PermisoId = 1, Permiso = "Descuenta" },
                    new Permisos() { PermisoId = 2, Permiso = "Vende" },
                    new Permisos() { PermisoId = 3, Permiso = "Cobra" }
                );
        }
    }
}
