using System;

namespace Practico01WF.Entidades
{
    public class Planta:ICloneable
    {
        public int PlantaId { get; set; }

        public string Descripcion { get; set; }

        public int TipoDePlantaId { get; set; }

        public int TipoDeEnvaseId { get; set; }

        public decimal PrecioCosto { get; set; }

        public decimal PrecioVenta { get; set; }

        public virtual TipoDeEnvase TipoDeEnvase { get; set; }

        public virtual TipoDePlanta TipoDePlanta { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
