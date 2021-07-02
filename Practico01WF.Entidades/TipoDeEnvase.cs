using System.Collections.Generic;

namespace Practico01WF.Entidades
{
    public class TipoDeEnvase
    {
        public TipoDeEnvase()
        {
           
        }

        public int TipoDeEnvaseId { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Planta> Plantas { get; set; } = new HashSet<Planta>();
    }
}
