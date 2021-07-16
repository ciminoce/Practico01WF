using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico01WF.Entidades;

namespace Practico01WF.UI.Helpers
{
    public class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow CrearFila(DataGridView dataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;
        }

        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            if (obj is TipoDeEnvase)
            {
                r.Cells[0].Value =((TipoDeEnvase)obj).Descripcion;

            }
            if (obj is TipoDePlanta)
            {
                r.Cells[0].Value =((TipoDePlanta)obj).Descripcion;

            }
           
            if (obj is Planta)
            {
                r.Cells[0].Value =((Planta)obj).Descripcion;
                r.Cells[1].Value = ((Planta)obj).TipoDePlanta.Descripcion;
                r.Cells[2].Value = ((Planta)obj).TipoDeEnvase.Descripcion;

            }
            r.Tag = obj;
        }
    }
}
