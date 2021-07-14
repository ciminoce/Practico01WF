using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
