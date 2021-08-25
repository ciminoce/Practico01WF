using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Practico01WF.Datos;
using Practico01WF.Datos.Repositorios;
using Practico01WF.Datos.Repositorios.Facades;
using Practico01WF.Servicios.Servicios;
using Practico01WF.Servicios.Servicios.Facades;

namespace Practico01WF.UI.Ninject
{
    public class Bindins : NinjectModule
    {
        public override void Load()
        {
            Bind<ViveroDbContext>().ToSelf().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IRepositorioTipoDePlanta>().To<RepositorioTipoDePlanta>();
            Bind<IServicioTipoDePlanta>().To<ServicioTipoDePlanta>();

            Bind<IRepositorioTipoDeEnvase>().To<RepositorioTipoDeEnvase>();
            Bind<IServicioTipoDeEnvase>().To<ServicioTipoDeEnvase>();

            Bind<IRepositorioPlanta>().To<RepositorioPlanta>();
            Bind<IServicioPlanta>().To<ServicioPlanta>();


        }
    }
}
