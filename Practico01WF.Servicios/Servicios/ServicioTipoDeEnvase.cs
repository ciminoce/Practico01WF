using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Datos.Repositorios;
using Practico01WF.Datos.Repositorios.Facades;
using Practico01WF.Entidades;
using Practico01WF.Servicios.Servicios.Facades;

namespace Practico01WF.Servicios.Servicios
{
    public class ServicioTipoDeEnvase:IServicioTipoDeEnvase
    {
        private IRepositorioTipoDeEnvase repositorio;

        public ServicioTipoDeEnvase()
        {
            repositorio = new RepositorioTipoDeEnvase();
        }
        public List<TipoDeEnvase> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public TipoDeEnvase GetTipoDeEnvasePorId(int id)
        {
            try
            {
                return repositorio.GetTipoDeEnvasePorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(TipoDeEnvase tipoDeEnvase)
        {
            try
            {
                repositorio.Guardar(tipoDeEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeEnvase tipoDeEnvase)
        {
            try
            {
                return repositorio.Existe(tipoDeEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeEnvase tipoDeEnvase)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return repositorio.GetCantidad();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<IGrouping<int, Planta>> GetGrupo()
        {
            try
            {
                return repositorio.GetGrupos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoDeEnvaseId)
        {
            try
            {
                repositorio.Borrar(tipoDeEnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
