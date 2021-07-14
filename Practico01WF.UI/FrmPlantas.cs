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
using Practico01WF.Entidades.Enums;
using Practico01WF.Servicios.Servicios;
using Practico01WF.Servicios.Servicios.Facades;
using Practico01WF.UI.Helpers;
using Practico01WF.UI.Properties;

namespace Practico01WF.UI
{
    public partial class FrmPlantas : Form
    {
        public FrmPlantas()
        {
            InitializeComponent();
        }

        private Filtro filtro = Filtro.Off;
        private IServicioPlanta servicio;
        private List<Planta> lista;
        private int cantidadRegistros;
        private int cantidadPaginas;
        private int cantidadPorPagina = 20;
        private int paginaActual;
        private void FrmPlantas_Load(object sender, EventArgs e)
        {
            servicio = new ServicioPlanta();
            InicializarGrilla();
        }

        private void InicializarGrilla()
        {
            try
            {
                cantidadRegistros = servicio.GetCantidad();
                cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros, cantidadPorPagina);
                CrearBotonesPaginado(cantidadPaginas);
                paginaActual = 1;
                MostrarPaginado(cantidadPorPagina, paginaActual);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearBotonesPaginado(int paginas)
        {
            BotonesPanel.Controls.Clear();
            for (int i = 0; i < paginas; i++)
            {
                Button b = new Button()
                {
                    Text = (i + 1).ToString(),
                    Location = new Point(16+(35*i), 16),
                    Size = new Size(32, 32)

                };
                b.Click += Miclick;//Le agrego un manejador al evento clic de los botones
                BotonesPanel.Controls.Add(b);//Agregro el botón a la colección de controles del panel
            }
        }

        private void Miclick(object sender, EventArgs e)
        {
            Button b =(Button) sender;
            paginaActual = int.Parse(b.Text);
            MostrarPaginado(cantidadPorPagina,paginaActual);
        }

        private int CalcularCantidadDePaginas(int totalRegistros, int porPagina)
        {
            if (totalRegistros<porPagina)
            {
                return 1;
            }

            if (totalRegistros%porPagina>0)
            {
                return totalRegistros / porPagina + 1;
            }
            else
            {
                return totalRegistros / porPagina;
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
        private void MostrarPaginado(int cantidadPorPagina, int paginaActual)
        {
            if (filtro==Filtro.Off)
            {
                lista = servicio.GetLista(cantidadPorPagina, paginaActual);
            }
            else
            {
                //lista = servicio.Find(p => p.TipoDePlantaId == 1, cantidadPorPagina, paginaActual);
                lista = servicio.Find(p => p.TipoDeEnvaseId == 1, cantidadPorPagina, paginaActual);
            }
            MostrarDatosEnGrilla();

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarPlanta frm = new FrmBuscarPlanta() {Text = "Seleccionar Filtros"};
            DialogResult dr = frm.ShowDialog(this);

            if (dr==DialogResult.OK)
            {
                //TODO:Ver que viene del form
                try
                {
                    filtro = Filtro.On;
                    tsbBuscar.Image = Resources.BuscarActivado;
                    //cantidadRegistros = servicio.GetCantidad(p => p.TipoDePlantaId == 1);
                    cantidadRegistros = servicio.GetCantidad(p => p.TipoDeEnvaseId == 1);

                    paginaActual = 1;

                    cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros, cantidadPorPagina);

                    CrearBotonesPaginado(cantidadPaginas);
                    MostrarPaginado(cantidadPorPagina, paginaActual);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            tsbBuscar.Image = Resources.Buscar;
            filtro = Filtro.Off;
            InicializarGrilla();
        }
    }
}
