
namespace Practico01WF.UI
{
    partial class FrmBuscarPorTipoDePlanta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TotalesTreeView = new System.Windows.Forms.TreeView();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDePlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TotalesTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 688);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 0;
            // 
            // TotalesTreeView
            // 
            this.TotalesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalesTreeView.Location = new System.Drawing.Point(0, 0);
            this.TotalesTreeView.Name = "TotalesTreeView";
            this.TotalesTreeView.Size = new System.Drawing.Size(399, 688);
            this.TotalesTreeView.TabIndex = 0;
            this.TotalesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TotalesTreeView_AfterSelect);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(719, 688);
            this.DatosDataGridView.TabIndex = 1;
            this.DatosDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDataGridView_RowEnter);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoDePlanta.DefaultCellStyle = dataGridViewCellStyle2;
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
            // FrmBuscarPorTipoDePlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBuscarPorTipoDePlanta";
            this.Text = "FrmBuscarPorTipoDePlanta";
            this.Load += new System.EventHandler(this.FrmBuscarPorTipoDePlanta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TotalesTreeView;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDePlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEnvase;
    }
}