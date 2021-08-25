using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Practico01WF.Reportes.Reportes;

namespace Practico01WF.UI
{
    public partial class FrmVisorReportes : Form
    {
        public FrmVisorReportes()
        {
            InitializeComponent();
        }

        private ReportClass _rpt;
        public void SetReporte(ListaDeTiposDeEnvases rpt)
        {
            _rpt = rpt;
        }

        private void FrmVisorReportes_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = _rpt;
        }
    }
}
