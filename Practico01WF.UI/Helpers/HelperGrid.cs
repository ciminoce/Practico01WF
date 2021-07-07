using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
