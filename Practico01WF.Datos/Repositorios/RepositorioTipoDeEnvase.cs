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
    public class RepositorioTipoDeEnvase:IRepositorioTipoDeEnvase
    {
        private ViveroDbContext context;

        public RepositorioTipoDeEnvase()
        {
            context = new ViveroDbContext();
        }
        public List<TipoDeEnvase> GetLista()
        {
            try
            {
                return context.TiposDeEnvases
                    .OrderBy(tp => tp.Descripcion)
                    .AsNoTracking().ToList();
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
                return context.TiposDeEnvases.SingleOrDefault(tp => tp.TipoDeEnvaseId == id);
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
                if (tipoDeEnvase.TipoDeEnvaseId == 0)
                {
                    //Cuando el id=0 entonces la entidad es nueva ==>alta
                    context.TiposDeEnvases.Add(tipoDeEnvase);

                }
                else
                {
                    var tipoDeEnvaseInDb =
                        context.TiposDeEnvases.SingleOrDefault(tp => tp.TipoDeEnvaseId == tipoDeEnvase.TipoDeEnvaseId);
                    if (tipoDeEnvaseInDb == null)
                    {
                        throw new Exception("Tipo de Envase inexistente");
                    }

                    tipoDeEnvaseInDb.Descripcion = tipoDeEnvase.Descripcion;
                    context.Entry(tipoDeEnvaseInDb).State = EntityState.Modified;

                }
                context.SaveChanges();

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
                if (tipoDeEnvase.TipoDeEnvaseId == 0)
                {
                    return context.TiposDeEnvases.Any(tp => tp.Descripcion == tipoDeEnvase.Descripcion);
                }

                return context.TiposDeEnvases.Any(tp => tp.Descripcion == tipoDeEnvase.Descripcion
                                                        && tp.TipoDeEnvaseId != tipoDeEnvase.TipoDeEnvaseId);
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
                return context.TiposDeEnvases.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public List<IGrouping<int, Planta>> GetGrupos()
        {
            try
            {
                return context.Plantas.GroupBy(p => p.TipoDeEnvaseId).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoDeEnvaseId)
        {
            TipoDeEnvase tipoInDb = null;
            try
            {
                tipoInDb = context.TiposDeEnvases
                    .SingleOrDefault(tp => tp.TipoDeEnvaseId == tipoDeEnvaseId);
                if (tipoInDb == null) return;
                context.Entry(tipoInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                context.Entry(tipoInDb).State = EntityState.Unchanged;
                throw new Exception(e.Message);
            }
        }
    }
}
