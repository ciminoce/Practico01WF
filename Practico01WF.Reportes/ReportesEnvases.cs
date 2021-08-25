using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Reportes
{
    public class ReportesEnvases
    {
        public static ViveroDataSet GetDatos(List<TipoDeEnvase> lista)
        {
            /* instancio el objeto ViveroDataSet */
            ViveroDataSet ds = new ViveroDataSet();

            /*Recorro la lista y por cada elemento de la misma
             voy agregando una fila en el datatable correspondiente tomando el
             nombre del envase únicamente*/
            foreach (var envase in lista)
            {
                ds.Tables["EnvasesDataTable"].Rows.Add(envase.Descripcion);

            }

            /*En este punto ya tengo todos los datos en el dataSet */
            return ds; // lo retorno la manejador de reportes
        }

    }
}
