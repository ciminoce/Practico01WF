using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Servicios.Servicios.Facades
{
    public interface IServicioTipoDePlanta
    {
        List<TipoDePlanta> GetLista();
        TipoDePlanta GetTipoDePlantaPorId(int id);
        void Guardar(TipoDePlanta tipoDePlanta);
        bool Existe(TipoDePlanta tipoDePlanta);
        bool EstaRelacionado(TipoDePlanta tipoDePlanta);
        int GetCantidad();
        List<IGrouping<int, Planta>> GetGrupo();
        void Borrar(int tipoDePlantaId);
    }
}
