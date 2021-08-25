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
        private readonly ViveroDbContext _context;

        public RepositorioTipoDeEnvase(ViveroDbContext context)
        {
            _context = context;
        }

        //public RepositorioTipoDeEnvase()
        //{
        //    _context = new ViveroDbContext();
        //}
        public List<TipoDeEnvase> GetLista()
        {
            try
            {
                return _context.TiposDeEnvases
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
                return _context.TiposDeEnvases.SingleOrDefault(tp => tp.TipoDeEnvaseId == id);
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
                    _context.TiposDeEnvases.Add(tipoDeEnvase);

                }
                else
                {
                    var tipoDeEnvaseInDb =
                        _context.TiposDeEnvases.SingleOrDefault(tp => tp.TipoDeEnvaseId == tipoDeEnvase.TipoDeEnvaseId);
                    if (tipoDeEnvaseInDb == null)
                    {
                        throw new Exception("Tipo de Envase inexistente");
                    }

                    tipoDeEnvaseInDb.Descripcion = tipoDeEnvase.Descripcion;
                    _context.Entry(tipoDeEnvaseInDb).State = EntityState.Modified;

                }
                //_context.SaveChanges();

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
                    return _context.TiposDeEnvases.Any(tp => tp.Descripcion == tipoDeEnvase.Descripcion);
                }

                return _context.TiposDeEnvases.Any(tp => tp.Descripcion == tipoDeEnvase.Descripcion
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
                return _context.TiposDeEnvases.Count();
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
                return _context.Plantas.GroupBy(p => p.TipoDeEnvaseId).ToList();
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
                tipoInDb = _context.TiposDeEnvases
                    .SingleOrDefault(tp => tp.TipoDeEnvaseId == tipoDeEnvaseId);
                if (tipoInDb == null) return;
                _context.Entry(tipoInDb).State = EntityState.Deleted;
                //_context.SaveChanges();
            }
            catch (Exception e)
            {
                _context.Entry(tipoInDb).State = EntityState.Unchanged;
                throw new Exception(e.Message);
            }
        }
    }
}
