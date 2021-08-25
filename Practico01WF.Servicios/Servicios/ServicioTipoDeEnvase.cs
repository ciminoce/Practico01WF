using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Datos;
using Practico01WF.Datos.Repositorios;
using Practico01WF.Datos.Repositorios.Facades;
using Practico01WF.Entidades;
using Practico01WF.Servicios.Servicios.Facades;

namespace Practico01WF.Servicios.Servicios
{
    public class ServicioTipoDeEnvase:IServicioTipoDeEnvase
    {
        private readonly IRepositorioTipoDeEnvase _repositorio;
        private readonly IUnitOfWork _unitOfWork;

        public ServicioTipoDeEnvase(IRepositorioTipoDeEnvase repositorio, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _unitOfWork = unitOfWork;
        }

        //public ServicioTipoDeEnvase()
        //{
        //    _repositorio = new RepositorioTipoDeEnvase();
        //}
        public List<TipoDeEnvase> GetLista()
        {
            try
            {
                return _repositorio.GetLista();
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
                return _repositorio.GetTipoDeEnvasePorId(id);
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
                _repositorio.Guardar(tipoDeEnvase);
                _unitOfWork.Save();
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
                return _repositorio.Existe(tipoDeEnvase);
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
                return _repositorio.GetCantidad();
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
                return _repositorio.GetGrupos();
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
                _repositorio.Borrar(tipoDeEnvaseId);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
