using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;
using Practico01WF.Reportes.Reportes;

namespace Practico01WF.Reportes
{
    public class ManejadorDeReportes
    {
        public static ListaDeTiposDeEnvases GetListadoDeTiposDeEnvases(List<TipoDeEnvase> lista)
        {
            ListaDeTiposDeEnvases rpt = new ListaDeTiposDeEnvases();
            ViveroDataSet ds = ReportesEnvases.GetDatos(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }

    }
}
