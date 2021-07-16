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

namespace Practico01WF.UI
{
    public partial class FrmPlantaEdit : Form
    {
        public FrmPlantaEdit()
        {
            InitializeComponent();
        }

        private IServicioPlanta servicio;
        private OperacionBd operacion=OperacionBd.Alta;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboTipoEnvase(ref TipoDeEnvaseComboBox);
            HelperCombo.CargarDatosComboTipoPlanta(ref TipoDePlantaComboBox);
            servicio = new ServicioPlanta();
            if (planta!=null)
            {
                PlantaTextBox.Text = planta.Descripcion;
                TipoDeEnvaseComboBox.SelectedValue = planta.TipoDeEnvaseId;
                TipoDePlantaComboBox.SelectedValue = planta.TipoDePlantaId;
                operacion = OperacionBd.Editar;
            }
        }

        private Planta planta;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (planta==null)
                {
                    planta = new Planta();
                }

                planta.Descripcion = PlantaTextBox.Text;
                planta.TipoDeEnvaseId = ((TipoDeEnvase) TipoDeEnvaseComboBox.SelectedItem).TipoDeEnvaseId;
                planta.TipoDePlantaId = ((TipoDePlanta)TipoDePlantaComboBox.SelectedItem).TipoDePlantaId;

                try
                {
                    if (servicio.Existe(planta))
                    {
                        errorProvider1.SetError(PlantaTextBox,"Planta inexistente");
                        return;
                    }
                    servicio.Guardar(planta);
                    MessageBox.Show("Registro guardado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (operacion==OperacionBd.Editar)
                {
                    DialogResult = DialogResult.OK;
                    return;
                    
                }
                    DialogResult dr = MessageBox.Show("¿Desea dar de alta otro registro?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr==DialogResult.No)
                    {
                        DialogResult = DialogResult.Cancel;
                    }

                    planta = null;
                    InicializarControles();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void InicializarControles()
        {
            PlantaTextBox.Clear();
            TipoDeEnvaseComboBox.SelectedIndex = 0;
            TipoDePlantaComboBox.SelectedIndex = 0;
            PlantaTextBox.Focus();
        }

        private bool ValidarDatos()
        {
            bool isValid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PlantaTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(PlantaTextBox,"Debe ingresar una planta");
            }

            if (TipoDeEnvaseComboBox.SelectedIndex==0)
            {
                isValid = false;
                errorProvider1.SetError(TipoDeEnvaseComboBox,"Debe seleccionar un tipo de envase");
            }

            if (TipoDePlantaComboBox.SelectedIndex==0)
            {
                isValid = false;
                errorProvider1.SetError(TipoDePlantaComboBox, "Debe seleccionar un tipo de planta");

            }

            return isValid;
        }

        public Planta GetPlanta()
        {
            return planta;
        }

        public void SetPlanta(Planta planta)
        {
            this.planta = planta;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
