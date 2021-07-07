using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico01WF.Entidades;
using Practico01WF.Servicios.Servicios;
using Practico01WF.Servicios.Servicios.Facades;
using Practico01WF.UI.Helpers;

namespace Practico01WF.UI
{
    public partial class FrmPlantas : Form
    {
        public FrmPlantas()
        {
            InitializeComponent();
        }

        private IServicioPlanta servicio;
        private List<Planta> lista;
        private int cantidadRegistros;
        private int cantidadPaginas;
        private int cantidadPorPagina = 20;
        private int paginaActual;
        private void FrmPlantas_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioPlanta();
                cantidadRegistros = servicio.GetCantidad();
                cantidadPaginas = cantidadRegistros / cantidadPorPagina + 1;
                paginaActual = 1;
                MostrarPaginado(cantidadPorPagina, paginaActual);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var planta in lista)
            {
                var r = HelperGrid.CrearFila(DatosDataGridView);
                SetearFila(r, planta);
                HelperGrid.AgregarFila(DatosDataGridView,r);
            }

            CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
            CantidadDePaginasLabel.Text = cantidadPaginas.ToString();
            PaginaActualLabel.Text = paginaActual.ToString();
        }

        private void SetearFila(DataGridViewRow r, Planta planta)
        {
            r.Cells[colPlanta.Index].Value = planta.Descripcion;
            r.Cells[colTipoDePlanta.Index].Value = planta.TipoDePlanta.Descripcion;
            r.Cells[colTipoEnvase.Index].Value = planta.TipoDeEnvase.Descripcion;

            r.Tag = planta;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual>cantidadPaginas)
            {
                paginaActual = cantidadPaginas;
            }
            MostrarPaginado(cantidadPorPagina, paginaActual);
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual<1)
            {
                paginaActual = 1;
            }
            MostrarPaginado(cantidadPorPagina, paginaActual);
        }

        private void UltimoButton_Click(object sender, EventArgs e)
        {
            paginaActual = cantidadPaginas;
            MostrarPaginado(cantidadPorPagina, paginaActual);
        }

        private void PrimeroButton_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado(cantidadPorPagina,paginaActual);
        }

        private void MostrarPaginado(int cantidadPorPagina, int paginaActual)
        {
            lista = servicio.GetLista(cantidadPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
    }
}
