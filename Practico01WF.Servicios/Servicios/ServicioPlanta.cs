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
    public class ServicioPlanta:IServicioPlanta
    {
        private readonly IRepositorioPlanta _repositorio;
        private readonly IUnitOfWork _unitOfWork;

        public ServicioPlanta(IRepositorioPlanta repositorio, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _unitOfWork = unitOfWork;
        }
        //public ServicioPlanta()
        //{
        //    _repositorio = new RepositorioPlanta();
        //}
        public List<Planta> GetLista(int registros, int pagina)
        {
            try
            {
                return _repositorio.GetLista(registros, pagina);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Planta> Find(Func<Planta, bool> predicate, int registros, int pagina)
        {
            try
            {
                return _repositorio.Find(predicate,registros,pagina);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Planta GetPlantaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Planta planta)
        {
            try
            {
                _repositorio.Guardar(planta);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Planta planta)
        {
            try
            {
                return _repositorio.Existe(planta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        public int GetCantidad(Func<Planta, bool> predicate)
        {
            try
            {
                return _repositorio.GetCantidad(predicate);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int plantaId)
        {
            try
            {
                _repositorio.Borrar(plantaId);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
