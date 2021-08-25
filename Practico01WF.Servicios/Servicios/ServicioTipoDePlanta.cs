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
    public class ServicioTipoDePlanta:IServicioTipoDePlanta
    {
        private readonly IRepositorioTipoDePlanta _repositorio;
        private readonly IUnitOfWork _unitOfWork;

        public ServicioTipoDePlanta(IRepositorioTipoDePlanta repositorio, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _unitOfWork = unitOfWork;
        }

        //public ServicioTipoDePlanta()
        //{
        //    _repositorio = new RepositorioTipoDePlanta();
        //}
        public List<TipoDePlanta> GetLista()
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

        public TipoDePlanta GetTipoDePlantaPorId(int id)
        {
            try
            {
                return _repositorio.GetTipoDePlantaPorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(TipoDePlanta tipoDePlanta)
        {
            try
            {
                _repositorio.Guardar(tipoDePlanta);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDePlanta tipoDePlanta)
        {
            try
            {
                return _repositorio.Existe(tipoDePlanta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDePlanta tipoDePlanta)
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

        public void Borrar(int tipoDePlantaId)
        {
            try
            {
                _repositorio.Borrar(tipoDePlantaId);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
