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
    public partial class FrmTiposDePlantas : Form
    {
        public FrmTiposDePlantas()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioTipoDePlanta servicio;
        private List<TipoDePlanta> lista;
        private int cantidadRegistros;
        private void FrmTiposDePlantas_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoDePlanta();
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
            foreach (var tipoDePlanta in lista)
            {
                DataGridViewRow r =HelperGrid.CrearFila(DatosDataGridView);

                HelperGrid.SetearFila(r, tipoDePlanta);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }

            CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
        }




        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmTipoDePlantaEdit frm = new FrmTipoDePlantaEdit() {Text = "Nuevo Tipo de Planta"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDePlanta tipoDePlanta = frm.GetTipo();
                    if (servicio.Existe(tipoDePlanta))
                    {
                        MessageBox.Show("Tipo de Planta existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    servicio.Guardar(tipoDePlanta);
                    DataGridViewRow r = HelperGrid.CrearFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, tipoDePlanta);
                    HelperGrid.AgregarFila(DatosDataGridView,r);
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
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TipoDePlanta tipoDePlanta = (TipoDePlanta) r.Tag;
            TipoDePlanta tipoDePlantaCopia =(TipoDePlanta) tipoDePlanta.Clone();
            FrmTipoDePlantaEdit frm = new FrmTipoDePlantaEdit() {Text = "Editar Tipo de Planta"};
            frm.SetTipo(tipoDePlanta);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoDePlanta = frm.GetTipo();
                if (servicio.Existe(tipoDePlanta))
                {
                    HelperGrid.SetearFila(r, tipoDePlantaCopia);
                    MessageBox.Show("Tipo de Planta existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                servicio.Guardar(tipoDePlanta);
                HelperGrid.SetearFila(r,tipoDePlanta);
                MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r,tipoDePlantaCopia);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TipoDePlanta tipoDePlanta = (TipoDePlanta) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro de {tipoDePlanta.Descripcion}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }

            try
            {
                servicio.Borrar(tipoDePlanta.TipoDePlantaId);
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
            FrmBuscarPorTipoDePlanta frm = new FrmBuscarPorTipoDePlanta() {Text = "Totales por Tipo de Planta"};
            frm.ShowDialog(this);
        }

    }

}
