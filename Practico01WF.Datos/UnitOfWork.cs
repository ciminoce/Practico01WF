using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Datos
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ViveroDbContext _context;

        public UnitOfWork(ViveroDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
