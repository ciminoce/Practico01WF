using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Datos.EntityTypeConfigurations
{
    public class PlantaEntityTypeConfiguration:EntityTypeConfiguration<Planta>
    {
        public PlantaEntityTypeConfiguration()
        {
            ToTable("Plantas");
            HasKey(p => p.PlantaId);
            Property(p => p.Descripcion).IsRequired().HasMaxLength(100);

        }
    }
}
