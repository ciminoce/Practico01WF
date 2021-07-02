using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico01WF.Entidades;

namespace Practico01WF.UI
{
    public partial class FrmTipoDePlantaEdit : Form
    {
        public FrmTipoDePlantaEdit()
        {
            InitializeComponent();
        }

        private TipoDePlanta tipoDePlanta;
        public TipoDePlanta GetTipo()
        {
            return tipoDePlanta;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDePlanta==null)
                {
                    tipoDePlanta = new TipoDePlanta();
                }

                tipoDePlanta.Descripcion = TipoDePlantaTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            if (string.IsNullOrEmpty(TipoDePlantaTextBox.Text))
            {
                esValido = false;
                errorProvider1.SetError(TipoDePlantaTextBox,"Debe ingresar una descripción");

            }

            return esValido;
        }

        public void SetTipo(TipoDePlanta tipoDePlanta)
        {
            this.tipoDePlanta = tipoDePlanta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDePlanta!=null)
            {
                TipoDePlantaTextBox.Text = tipoDePlanta.Descripcion;
            }
        }
    }
}
