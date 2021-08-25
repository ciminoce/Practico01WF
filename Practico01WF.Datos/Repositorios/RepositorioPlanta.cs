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
    public class RepositorioPlanta:IRepositorioPlanta
    {
        private readonly ViveroDbContext _context;

        public RepositorioPlanta(ViveroDbContext context)
        {
            _context = context;
        }
        //public RepositorioPlanta()
        //{
        //    _context = new ViveroDbContext();
        //}
        public List<Planta> GetLista(int cantidad, int pagina)
        {
            try
            {
                return _context.Plantas
                    .Include(p => p.TipoDePlanta)
                    .Include(p => p.TipoDeEnvase)
                    .OrderBy(p=>p.PlantaId)
                    .Skip(cantidad*(pagina-1))
                    .Take(cantidad)
                    .AsNoTracking()
                    .ToList();
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
                return _context.Plantas.Where(predicate)
                    .OrderBy(p=>p.PlantaId)
                    .Skip(registros*(pagina-1))
                    .Take(registros)
                    .ToList();
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
                _context.TiposDePlantas.Attach(planta.TipoDePlanta);
                _context.TiposDeEnvases.Attach(planta.TipoDeEnvase);

                if (planta.PlantaId==0)
                {
                    _context.Plantas.Add(planta);
                }
                else
                {
                    var plantaInDb = _context.Plantas.SingleOrDefault(p => p.PlantaId == planta.PlantaId);
                    if (plantaInDb==null)
                    {
                        throw new Exception("Planta inexistente");
                    }

                    plantaInDb.Descripcion = planta.Descripcion;
                    plantaInDb.TipoDeEnvaseId = planta.TipoDeEnvaseId;
                    plantaInDb.TipoDePlantaId = plantaInDb.TipoDePlantaId;

                    _context.Entry(plantaInDb).State = EntityState.Modified;

                }

                //_context.SaveChanges();
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
                if (planta.PlantaId == 0)
                {
                    return _context.Plantas.Any(p=>p.Descripcion==planta.Descripcion);
                }
                else
                {
                    return _context.Plantas
                        .Any(p => p.Descripcion == planta.Descripcion && p.PlantaId!=planta.PlantaId);

                }
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
                return _context.Plantas.Count();
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
                return _context.Plantas.Count(predicate);
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
                var plantaInDb = _context.Plantas.SingleOrDefault(p => p.PlantaId == plantaId);
                if (plantaInDb==null)
                {
                    throw new Exception("Planta inexistente");

                }

                _context.Entry(plantaInDb).State = EntityState.Deleted;
                //_context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
