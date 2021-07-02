using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Practico01WF.Entidades;

namespace Practico01WF.Datos
{
    public class ViveroDbContext : DbContext
    {
        public ViveroDbContext()
            : base("name=ViveroDbContext")
        {
        }

        public virtual DbSet<Planta> Plantas { get; set; }
        public virtual DbSet<TipoDeEnvase> TiposDeEnvases { get; set; }
        public virtual DbSet<TipoDePlanta> TiposDePlantas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ViveroDbContext>(null);//no usar migraciones
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//evita el borrado en cascada
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly()); //le digo que toma las configuraciones del assembly actual

        }
    }
}
