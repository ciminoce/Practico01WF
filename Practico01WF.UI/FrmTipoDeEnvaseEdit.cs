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

namespace Practico01WF.UI
{
    public partial class FrmTipoDeEnvaseEdit : Form
    {
        public FrmTipoDeEnvaseEdit()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeEnvase != null)
            {
                TipoDeEnvaseTextBox.Text = tipoDeEnvase.Descripcion;
            }
        }

        private TipoDeEnvase tipoDeEnvase;
        public void SetTipo(TipoDeEnvase tipoDeEnvase)
        {
            this.tipoDeEnvase = tipoDeEnvase;
        }

        public TipoDeEnvase GetTipo()
        {
            return tipoDeEnvase;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeEnvase==null)
                {
                    tipoDeEnvase = new TipoDeEnvase();
                }

                tipoDeEnvase.Descripcion = TipoDeEnvaseTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            if (string.IsNullOrEmpty(TipoDeEnvaseTextBox.Text))
            {
                esValido = false;
                errorProvider1.SetError(TipoDeEnvaseTextBox, "Debe ingresar una descripción");

            }

            return esValido;
        }

    }
}
