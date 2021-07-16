
namespace Practico01WF.UI
{
    partial class FrmPlantas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDePlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonesPanel = new System.Windows.Forms.Panel();
            this.CantidadDePaginasLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginaActualLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadDeRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BotonesPanel);
            this.splitContainer1.Panel2.Controls.Add(this.CantidadDePaginasLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.PaginaActualLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.CantidadDeRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(855, 599);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 13;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlanta,
            this.colTipoDePlanta,
            this.colTipoEnvase});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(855, 501);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colPlanta
            // 
            this.colPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlanta.HeaderText = "Planta";
            this.colPlanta.Name = "colPlanta";
            this.colPlanta.ReadOnly = true;
            // 
            // colTipoDePlanta
            // 
            this.colTipoDePlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoDePlanta.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTipoDePlanta.HeaderText = "Tipo de Planta";
            this.colTipoDePlanta.Name = "colTipoDePlanta";
            this.colTipoDePlanta.ReadOnly = true;
            this.colTipoDePlanta.Width = 93;
            // 
            // colTipoEnvase
            // 
            this.colTipoEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTipoEnvase.HeaderText = "Tipo de Envase";
            this.colTipoEnvase.Name = "colTipoEnvase";
            this.colTipoEnvase.ReadOnly = true;
            this.colTipoEnvase.Width = 98;
            // 
            // BotonesPanel
            // 
            this.BotonesPanel.Location = new System.Drawing.Point(234, 20);
            this.BotonesPanel.Name = "BotonesPanel";
            this.BotonesPanel.Size = new System.Drawing.Size(603, 54);
            this.BotonesPanel.TabIndex = 2;
            // 
            // CantidadDePaginasLabel
            // 
            this.CantidadDePaginasLabel.AutoSize = true;
            this.CantidadDePaginasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDePaginasLabel.Location = new System.Drawing.Point(194, 45);
            this.CantidadDePaginasLabel.Name = "CantidadDePaginasLabel";
            this.CantidadDePaginasLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadDePaginasLabel.TabIndex = 1;
            this.CantidadDePaginasLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "de";
            // 
            // PaginaActualLabel
            // 
            this.PaginaActualLabel.AutoSize = true;
            this.PaginaActualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginaActualLabel.Location = new System.Drawing.Point(134, 45);
            this.PaginaActualLabel.Name = "PaginaActualLabel";
            this.PaginaActualLabel.Size = new System.Drawing.Size(14, 13);
            this.PaginaActualLabel.TabIndex = 1;
            this.PaginaActualLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Página:";
            // 
            // CantidadDeRegistrosLabel
            // 
            this.CantidadDeRegistrosLabel.AutoSize = true;
            this.CantidadDeRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDeRegistrosLabel.Location = new System.Drawing.Point(134, 20);
            this.CantidadDeRegistrosLabel.Name = "CantidadDeRegistrosLabel";
            this.CantidadDeRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadDeRegistrosLabel.TabIndex = 1;
            this.CantidadDeRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbBuscar,
            this.tsbActualizar,
            this.toolStripSeparator2,
            this.tsbImprimir,
            this.toolStripSeparator3,
            this.tsbCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 62);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::Practico01WF.UI.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 59);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.Image = global::Practico01WF.UI.Properties.Resources.Delete;
            this.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(44, 59);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::Practico01WF.UI.Properties.Resources.Edit;
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(44, 59);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::Practico01WF.UI.Properties.Resources.Buscar;
            this.tsbBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(46, 59);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.Image = global::Practico01WF.UI.Properties.Resources.Update;
            this.tsbActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 59);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbActualizar.Click += new System.EventHandler(this.tsbActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Image = global::Practico01WF.UI.Properties.Resources.Print;
            this.tsbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(57, 59);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Image = global::Practico01WF.UI.Properties.Resources.Close;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(44, 59);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // FrmPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPlantas";
            this.Text = "FrmPlantas";
            this.Load += new System.EventHandler(this.FrmPlantas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDePlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEnvase;
        private System.Windows.Forms.Label CantidadDeRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Label CantidadDePaginasLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PaginaActualLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BotonesPanel;
    }
}