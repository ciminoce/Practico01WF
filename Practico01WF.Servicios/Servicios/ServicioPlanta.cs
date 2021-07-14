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
    public class ServicioPlanta:IServicioPlanta
    {
        private IRepositorioPlanta repositorio;

        public ServicioPlanta()
        {
            repositorio = new RepositorioPlanta();
        }
        public List<Planta> GetLista(int registros, int pagina)
        {
            try
            {
                return repositorio.GetLista(registros, pagina);
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
                return repositorio.Find(predicate,registros,pagina);
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
            throw new NotImplementedException();
        }

        public bool Existe(Planta planta)
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

        public int GetCantidad(Func<Planta, bool> predicate)
        {
            try
            {
                return repositorio.GetCantidad(predicate);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int plantaId)
        {
            throw new NotImplementedException();
        }
    }
}
