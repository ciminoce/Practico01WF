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
        private readonly ViveroDbContext _context;

        public RepositorioTipoDePlanta(ViveroDbContext context)
        {
            _context = context;
        }

        //public RepositorioTipoDePlanta()
        //{
        //    _context = new ViveroDbContext();
        //}
        public List<TipoDePlanta> GetLista()
        {
            try
            {
                return _context.TiposDePlantas
                    .OrderBy(tp=>tp.Descripcion)
                    .AsNoTracking().ToList();
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
                return _context.TiposDePlantas.SingleOrDefault(tp => tp.TipoDePlantaId == id);
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
                    _context.TiposDePlantas.Add(tipoDePlanta);
                    
                }
                else
                {
                    var tipoDePlantaInDb =
                        _context.TiposDePlantas.SingleOrDefault(tp => tp.TipoDePlantaId == tipoDePlanta.TipoDePlantaId);
                    if (tipoDePlantaInDb==null)
                    {
                        throw new Exception("Tipo de Planta inexistente");
                    }

                    tipoDePlantaInDb.Descripcion = tipoDePlanta.Descripcion;
                    _context.Entry(tipoDePlantaInDb).State = EntityState.Modified;
                    
                }
                //_context.SaveChanges();
                
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
                    return _context.TiposDePlantas.Any(tp => tp.Descripcion == tipoDePlanta.Descripcion);
                }

                return _context.TiposDePlantas.Any(tp => tp.Descripcion == tipoDePlanta.Descripcion
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
                return _context.TiposDePlantas.Count();
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
                return _context.Plantas.GroupBy(p=>p.TipoDePlantaId).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoDePlantaId)
        {
            TipoDePlanta tipoInDb=null;
            try
            {
                tipoInDb = _context.TiposDePlantas
                    .SingleOrDefault(tp => tp.TipoDePlantaId == tipoDePlantaId);
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
