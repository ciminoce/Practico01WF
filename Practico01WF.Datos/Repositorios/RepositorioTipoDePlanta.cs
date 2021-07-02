using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Datos.Repositorios.Facades;
using Practico01WF.Entidades;

namespace Practico01WF.Datos.Repositorios
{
    public class RepositorioTipoDePlanta:IRepositorioTipoDePlanta
    {
        private ViveroDbContext context;

        public RepositorioTipoDePlanta()
        {
            context = new ViveroDbContext();
        }
        public List<TipoDePlanta> GetLista()
        {
            try
            {
                return context.TiposDePlantas.ToList();
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
                return context.TiposDePlantas.SingleOrDefault(tp => tp.TipoDePlantaId == id);
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
                if (tipoDePlanta.TipoDePlantaId==0)
                {
                    //Cuando el id=0 entonces la entidad es nueva ==>alta
                    context.TiposDePlantas.Add(tipoDePlanta);
                    
                }
                else
                {
                    var tipoDePlantaInDb =
                        context.TiposDePlantas.SingleOrDefault(tp => tp.TipoDePlantaId == tipoDePlanta.TipoDePlantaId);
                    if (tipoDePlantaInDb==null)
                    {
                        throw new Exception("Tipo de Planta inexistente");
                    }

                    tipoDePlantaInDb.Descripcion = tipoDePlanta.Descripcion;
                    context.Entry(tipoDePlantaInDb).State = EntityState.Modified;
                    
                }
                context.SaveChanges();
                
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
                if (tipoDePlanta.TipoDePlantaId==0)
                {
                    return context.TiposDePlantas.Any(tp => tp.Descripcion == tipoDePlanta.Descripcion);
                }

                return context.TiposDePlantas.Any(tp => tp.Descripcion == tipoDePlanta.Descripcion
                                                        && tp.TipoDePlantaId != tipoDePlanta.TipoDePlantaId);
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
                return context.TiposDePlantas.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
