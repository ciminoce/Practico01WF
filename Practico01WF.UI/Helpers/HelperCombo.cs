using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico01WF.Entidades;
using Practico01WF.Servicios.Servicios;
using Practico01WF.Servicios.Servicios.Facades;
using Practico01WF.UI.Ninject;

namespace Practico01WF.UI.Helpers
{
    public class HelperCombo
    {
        public static void CargarDatosComboTipoPlanta(ref ComboBox combo)
        {
            //IServicioTipoDePlanta servicio = new ServicioTipoDePlanta();
            IServicioTipoDePlanta servicio = DI.Create<IServicioTipoDePlanta>();
            List<TipoDePlanta> lista = servicio.GetLista();
            TipoDePlanta defaultTipo = new TipoDePlanta()
            {
                TipoDePlantaId = 0,
                Descripcion = "<Seleccione un tipo de planta>"
            };
            lista.Insert(0,defaultTipo);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDePlantaId";
            combo.SelectedIndex = 0;

        }
        public static void CargarDatosComboTipoEnvase(ref ComboBox combo)
        {
            //IServicioTipoDeEnvase servicio = new ServicioTipoDeEnvase();
            IServicioTipoDeEnvase servicio = DI.Create<IServicioTipoDeEnvase>();
            List<TipoDeEnvase> lista = servicio.GetLista();
            TipoDeEnvase defaultTipo = new TipoDeEnvase()
            {
                TipoDeEnvaseId = 0,
                Descripcion = "<Seleccione un tipo de envase>"
            };
            lista.Insert(0, defaultTipo);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDeEnvaseId";
            combo.SelectedIndex = 0;

        }

    }
}
