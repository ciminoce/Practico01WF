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
    public class ServicioTipoDePlanta:IServicioTipoDePlanta
    {
        private IRepositorioTipoDePlanta repositorio;

        public ServicioTipoDePlanta()
        {
            repositorio = new RepositorioTipoDePlanta();
        }
        public List<TipoDePlanta> GetLista()
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

        public TipoDePlanta GetTipoDePlantaPorId(int id)
        {
            try
            {
                return repositorio.GetTipoDePlantaPorId(id);
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
                repositorio.Guardar(tipoDePlanta);
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
                return repositorio.Existe(tipoDePlanta);
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
                return repositorio.GetCantidad();
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
                repositorio.Borrar(tipoDePlantaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
