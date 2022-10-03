using ElPanelDeControl.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.AccesoADatos
{
    class LecturasContext : DbContext
    {
        public LecturasContext() : base("name=LecturasConnection")
        {

        }

        public DbSet<Lectura> Lecturas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Lectura>()
                .HasKey(l => l.Id)
                .ToTable("Lecturas");               
            

            base.OnModelCreating(modelBuilder);
        }

    }
}
