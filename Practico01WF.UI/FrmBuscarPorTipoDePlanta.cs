using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
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
    public partial class FrmBuscarPorTipoDePlanta : Form
    {
        public FrmBuscarPorTipoDePlanta(IServicioTipoDePlanta servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private readonly IServicioTipoDePlanta _servicio;
        private List<IGrouping<int, Planta>> grupo;
        private void FrmBuscarPorTipoDePlanta_Load(object sender, EventArgs e)
        {
            //servicio = new ServicioTipoDePlanta();
            grupo = _servicio.GetGrupo();
            PopulateTreeView();//Llenar el treeview
        }

        //Método para llenar el treeview
        private void PopulateTreeView()
        {
            TreeNode mainNode = new TreeNode();//Nodo principal
            mainNode.Name = "mainNode";
            mainNode.Text = "Principal";
            this.TotalesTreeView.Nodes.Add(mainNode);//Lo agrego al treeview
            //Recorrer el grupo recibido
            foreach (var g in grupo)
            {
                var tipo = _servicio.GetTipoDePlantaPorId(g.Key);//busco el tipo de planta
                TreeNode nodoTipo = new TreeNode($"{tipo.Descripcion} - Cantidad={g.Count()}");//creo el nodo
                nodoTipo.Tag = tipo;
                foreach (var planta in g)//Recorro el detalle de plantas agrupadas
                {
                    TreeNode nodoPlanta = new TreeNode($"{planta.Descripcion} - {planta.PrecioVenta}");
                    nodoPlanta.Tag = planta;
                    nodoTipo.Nodes.Add(nodoPlanta);//Al nodo del tipo de planta le voy agregando los nodos de las plantas
                }

                mainNode.Nodes.Add(nodoTipo);//Agrego el nodo del tipo al nodo principal.
            }
        }

        private void TotalesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode nodo = e.Node;
            switch (nodo.Level)
            {
                case 0:
                    HelperGrid.LimpiarGrilla(DatosDataGridView);
                    break;

                case 1:
                    TipoDePlanta tipo = (TipoDePlanta)nodo.Tag;
                    var listaFiltrada = grupo[e.Node.Index].ToList();
                    PopulateGrid(listaFiltrada);
                    break;

                case 2:
                    Planta planta = (Planta)nodo.Tag;
                    SeleccionarFila(planta);
                    break;
            }

        }

        private void SeleccionarFila(Planta planta)
        {
            foreach (DataGridViewRow row in DatosDataGridView.Rows)
            {
                Planta p = (Planta)row.Tag;
                if (p.Equals(planta))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void PopulateGrid(List<Planta> listaFiltrada)
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var planta in listaFiltrada)
            {
                var r = HelperGrid.CrearFila(DatosDataGridView);
                HelperGrid.SetearFila(r, planta);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }

        private void DatosDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DataGridViewRow r = DatosDataGridView.Rows[e.RowIndex];
                Planta planta = (Planta)r.Tag;
                TreeNode nodoSeleccionado = BuscarNodoNivelDos(planta);
                TotalesTreeView.HideSelection = false;
                TotalesTreeView.SelectedNode = nodoSeleccionado;
            }

        }

        private TreeNode BuscarNodoNivelDos(Planta planta)
        {
            //Primero recorro la coleccion de nodos de tipos de tipos
            foreach (TreeNode nodoTipo in TotalesTreeView.Nodes[0].Nodes)
            {
                //De cada nodo tipo de planta, recorro su coleccion de nodos (plantas)
                foreach (TreeNode nodoPlanta in nodoTipo.Nodes)
                {
                    //Tomar la planta del nodo
                    var plantaNodo = (Planta)nodoPlanta.Tag;
                    //Comparo dicha planta con la planta que me pasan
                    if (planta.Equals(plantaNodo))
                    {
                        return nodoPlanta;
                    }
                }
            }

            return null;
        }
    }
}
