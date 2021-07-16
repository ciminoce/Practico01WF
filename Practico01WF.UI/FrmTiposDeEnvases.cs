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
    public partial class FrmTiposDeEnvases : Form
    {
        public FrmTiposDeEnvases()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioTipoDeEnvase servicio;
        private List<TipoDeEnvase> lista;
        private int cantidadRegistros;
        private void FrmTiposDeEnvases_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoDeEnvase();
            try
            {
                lista = servicio.GetLista();
                cantidadRegistros = servicio.GetCantidad();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var tipoDeEnvase in lista)
            {
                DataGridViewRow r = HelperGrid.CrearFila(DatosDataGridView);

                HelperGrid.SetearFila(r, tipoDeEnvase);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }

            CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
        }




        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmTipoDeEnvaseEdit frm = new FrmTipoDeEnvaseEdit() { Text = "Nuevo Tipo de Planta" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDeEnvase tipoDeEnvase = frm.GetTipo();
                    if (servicio.Existe(tipoDeEnvase))
                    {
                        MessageBox.Show("Tipo de Planta existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    servicio.Guardar(tipoDeEnvase);
                    DataGridViewRow r = HelperGrid.CrearFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, tipoDeEnvase);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                    cantidadRegistros = servicio.GetCantidad();
                    MessageBox.Show("Registro guardado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TipoDeEnvase tipoDeEnvase = (TipoDeEnvase)r.Tag;
            TipoDeEnvase tipoDeEnvaseCopia = (TipoDeEnvase)tipoDeEnvase.Clone();
            FrmTipoDeEnvaseEdit frm = new FrmTipoDeEnvaseEdit() { Text = "Editar Tipo de Planta" };
            frm.SetTipo(tipoDeEnvase);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoDeEnvase = frm.GetTipo();
                if (servicio.Existe(tipoDeEnvase))
                {
                    HelperGrid.SetearFila(r, tipoDeEnvaseCopia);
                    MessageBox.Show("Tipo de Planta existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                servicio.Guardar(tipoDeEnvase);
                HelperGrid.SetearFila(r, tipoDeEnvase);
                MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, tipoDeEnvaseCopia);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TipoDeEnvase tipoDeEnvase = (TipoDeEnvase)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro de {tipoDeEnvase.Descripcion}?",
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
                servicio.Borrar(tipoDeEnvase.TipoDeEnvaseId);
                HelperGrid.BorrarFila(DatosDataGridView, r);

                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Registro relacionado... Baja denegada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
        }

    }
}
