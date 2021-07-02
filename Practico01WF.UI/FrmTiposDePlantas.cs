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
            catch (Exception exception)
            {
                
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var tipoDePlanta in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDePlanta);
                AgregarFila(r);
            }

            CantidadDeRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDePlanta tipoDePlanta)
        {
            r.Cells[colTipoDePlanta.Index].Value = tipoDePlanta.Descripcion;

            r.Tag = tipoDePlanta;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
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
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, tipoDePlanta);
                    AgregarFila(r);
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
                    MessageBox.Show("Tipo de Planta existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                servicio.Guardar(tipoDePlanta);
                SetearFila(r,tipoDePlanta);
                MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
