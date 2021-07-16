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
using Practico01WF.UI.Helpers;

namespace Practico01WF.UI
{
    public partial class FrmBuscarPlanta : Form
    {
        public FrmBuscarPlanta()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmBuscarPlanta_Load(object sender, EventArgs e)
        {
            HelperCombo.CargarDatosComboTipoEnvase(ref TipoDeEnvaseComboBox);
            HelperCombo.CargarDatosComboTipoPlanta(ref TipoDePlantaComboBox);
        }

        private void TipoDePlantaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoDePlantaRadioButton.Checked)
            {
                TipoDePlantaComboBox.Enabled = true;
            }
            else
            {
                TipoDeEnvaseComboBox.Enabled = false;
            }
        }
        private TipoDePlanta tipoDePlanta=null;
        private TipoDeEnvase tipoDeEnvase=null;

        public TipoDeEnvase GetTipoEnvase()
        {
            return tipoDeEnvase;
        }

        public TipoDePlanta GetTipoPlanta()
        {
            return tipoDePlanta;
        }


        private void TipoDePlantaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoDePlantaComboBox.SelectedIndex > 0)
            {
                tipoDePlanta = (TipoDePlanta)TipoDePlantaComboBox.SelectedItem;
                tipoDeEnvase = null;
            }
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool isValid = true;
            if (TipoDePlantaComboBox.SelectedIndex == 0 && TipoDeEnvaseComboBox.SelectedIndex == 0)
            {
                isValid = false;
                MessageBox.Show("Debe seleccionar un tipo de planta o envase", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void TipoDeEnvaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoDeEnvaseRadioButton.Checked)
            {
                TipoDeEnvaseComboBox.Enabled = true;
            }
            else
            {
                TipoDeEnvaseComboBox.Enabled = false;
                tipoDeEnvase = null;
            }

        }

        private void TipoDeEnvaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoDeEnvaseComboBox.SelectedIndex > 0)
            {
                tipoDeEnvase = (TipoDeEnvase)TipoDeEnvaseComboBox.SelectedItem;
                tipoDePlanta = null;
            }

        }

    }
}
