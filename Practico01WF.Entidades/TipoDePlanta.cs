using System.Collections.Generic;

namespace Practico01WF.Entidades
{
    public class TipoDePlanta
    {
        public TipoDePlanta()
        {
            
        }

        public int TipoDePlantaId { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Planta> Plantas { get; set; }= new HashSet<Planta>();
    }
}
