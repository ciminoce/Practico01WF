using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Datos.Repositorios.Facades
{
    public interface IRepositorioTipoDeEnvase
    {
        List<TipoDeEnvase> GetLista();
        TipoDeEnvase GetTipoDeEnvasePorId(int id);
        void Guardar(TipoDeEnvase tipoDeEnvase);
        bool Existe(TipoDeEnvase tipoDeEnvase);
        bool EstaRelacionado(TipoDeEnvase tipoDeEnvase);
        int GetCantidad();
        List<IGrouping<int, Planta>> GetGrupos();
        void Borrar(int tipoDeEnvaseId);

    }
}
