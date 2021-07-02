using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Datos.EntityTypeConfigurations
{
    public class TipoDePlantaEntityTypeConfiguration:EntityTypeConfiguration<TipoDePlanta>
    {
        public TipoDePlantaEntityTypeConfiguration()
        {
            ToTable("TiposDePlantas");//Indico con que tabla trabaja la entidad
            HasKey(tp => tp.TipoDePlantaId);//Indico el campo clave principal
            Property(tp => tp.Descripcion).IsRequired().HasMaxLength(50);//Indico que es requerido y con una long max de 50

        }
    }
}
