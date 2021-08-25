using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico01WF.Servicios.Servicios.Facades;
using Practico01WF.UI.Ninject;

namespace Practico01WF.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TiposDePlantasButton_Click(object sender, EventArgs e)
        {
            FrmTiposDePlantas frm = new FrmTiposDePlantas(DI.Create<IServicioTipoDePlanta>());
            frm.ShowDialog(this);
        }

        private void PlantasButton_Click(object sender, EventArgs e)
        {
            FrmPlantas frm = new FrmPlantas(DI.Create<IServicioPlanta>());
            frm.ShowDialog(this);
        }

        private void TiposDeEnvasesButton_Click(object sender, EventArgs e)
        {
            FrmTiposDeEnvases frm = new FrmTiposDeEnvases(DI.Create<IServicioTipoDeEnvase>());
            frm.ShowDialog(this);
        }
    }
}
