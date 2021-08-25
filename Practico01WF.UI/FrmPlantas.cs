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
using Practico01WF.UI.Ninject;
using Practico01WF.UI.Properties;

namespace Practico01WF.UI
{
    public partial class FrmPlantas : Form
    {
        public FrmPlantas(IServicioPlanta servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private Filtro filtro = Filtro.Off;
        private TipoDeEnvase filtroEnvase;
        private TipoDePlanta filtroPlanta;

        private readonly IServicioPlanta _servicio;
        private List<Planta> lista;
        private int cantidadRegistros;
        private int cantidadPaginas;
        private int cantidadPorPagina = 20;
        private int paginaActual;
        private void FrmPlantas_Load(object sender, EventArgs e)
        {
            //servicio = new ServicioPlanta();
            InicializarGrilla();
        }

        private void InicializarGrilla()
        {
            try
            {
                cantidadRegistros = _servicio.GetCantidad();
                cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros, cantidadPorPagina);
                CrearBotonesPaginas(cantidadPaginas);
                paginaActual = 1;
                MostrarPaginado(cantidadPorPagina, paginaActual);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearBotonesPaginas(int paginas)
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
                HelperGrid.SetearFila(r, planta);
                HelperGrid.AgregarFila(DatosDataGridView,r);
            }

            CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
            CantidadDePaginasLabel.Text = cantidadPaginas.ToString();
            PaginaActualLabel.Text = paginaActual.ToString();
        }


        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MostrarPaginado(int cantidadPorPagina, int paginaActual)
        {
            if (filtro==Filtro.Off)
            {
                lista = _servicio.GetLista(cantidadPorPagina, paginaActual);
            }
            else if(filtro==Filtro.TipoEnvase)
            {
                lista = _servicio.Find(p => p.TipoDeEnvaseId == filtroEnvase.TipoDeEnvaseId, cantidadPorPagina, paginaActual);
            }
            else if(filtro==Filtro.TipoPlanta)
            {
                lista = _servicio.Find(p => p.TipoDePlantaId == filtroPlanta.TipoDePlantaId, cantidadPorPagina, paginaActual);
                
            }
            MostrarDatosEnGrilla();

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarPlanta frm = new FrmBuscarPlanta() { Text = "Seleccione Filtro" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                tsbBuscar.Image = Resources.BuscarActivado;
                if (frm.GetTipoEnvase() != null)
                {

                    filtroEnvase = frm.GetTipoEnvase();
                    cantidadRegistros = _servicio.GetCantidad(p => p.TipoDeEnvaseId == filtroEnvase.TipoDeEnvaseId);
                    cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros, cantidadPorPagina);
                    CrearBotonesPaginas(cantidadPaginas);
                    paginaActual = 1;
                    filtro = Filtro.TipoEnvase;
                    MostrarPaginado(cantidadPorPagina, paginaActual);
                }
                else
                {
                    filtroPlanta = frm.GetTipoPlanta();
                    cantidadRegistros = _servicio.GetCantidad(p => p.TipoDePlantaId == filtroPlanta.TipoDePlantaId);
                    cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros, cantidadPorPagina);
                    CrearBotonesPaginas(cantidadPaginas);
                    paginaActual = 1;
                    filtro = Filtro.TipoPlanta;
                    MostrarPaginado(cantidadPorPagina, paginaActual);
                }
            }

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            tsbBuscar.Image = Resources.Buscar;
            filtro = Filtro.Off;
            InicializarGrilla();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmPlantaEdit frm = new FrmPlantaEdit(DI.Create<IServicioPlanta>()) { Text = "Nueva Planta" };
            DialogResult dr = frm.ShowDialog(this);
            InicializarGrilla();

            //if (dr == DialogResult.OK)
            //{
            //    try
            //    {
            //        Planta planta = frm.GetPlanta();
            //        if (servicio.Existe(planta))
            //        {
            //            MessageBox.Show("Planta existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        servicio.Guardar(planta);
            //        DataGridViewRow r = HelperGrid.CrearFila(DatosDataGridView);
            //        HelperGrid.SetearFila(r, planta);
            //        HelperGrid.AgregarFila(DatosDataGridView, r);
            //        cantidadRegistros = servicio.GetCantidad();
            //        MessageBox.Show("Registro guardado", "Mensaje",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Planta planta = (Planta)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro de {planta.Descripcion}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                _servicio.Borrar(planta.PlantaId);
                HelperGrid.BorrarFila(DatosDataGridView, r);

                cantidadRegistros = _servicio.GetCantidad();
                CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
                cantidadPaginas = CalcularCantidadDePaginas(cantidadRegistros,cantidadPorPagina);
                CrearBotonesPaginas(cantidadPaginas);

                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Registro relacionado... Baja denegada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Planta planta = (Planta)r.Tag;
            Planta plantaCopia = (Planta)planta.Clone();
            FrmPlantaEdit frm = new FrmPlantaEdit(DI.Create<IServicioPlanta>()) { Text = "Editar Planta" };
            frm.SetPlanta(planta);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            MostrarPaginado(cantidadPorPagina, paginaActual);
            //try
            //{
            //    planta = frm.GetPlanta();
            //    if (servicio.Existe(planta))
            //    {
            //        HelperGrid.SetearFila(r, plantaCopia);
            //        MessageBox.Show("Tipo de Planta existente", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    servicio.Guardar(planta);
            //    HelperGrid.SetearFila(r, planta);
            //    MessageBox.Show("Registro Editado", "Mensaje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception exception)
            //{
            //    HelperGrid.SetearFila(r, plantaCopia);
            //    MessageBox.Show(exception.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
    }
}
