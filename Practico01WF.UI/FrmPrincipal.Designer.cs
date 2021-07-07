
namespace Practico01WF.UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TiposDePlantasButton = new System.Windows.Forms.Button();
            this.TiposDeEnvasesButton = new System.Windows.Forms.Button();
            this.PlantasButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TiposDePlantasButton
            // 
            this.TiposDePlantasButton.Location = new System.Drawing.Point(53, 75);
            this.TiposDePlantasButton.Name = "TiposDePlantasButton";
            this.TiposDePlantasButton.Size = new System.Drawing.Size(143, 72);
            this.TiposDePlantasButton.TabIndex = 0;
            this.TiposDePlantasButton.Text = "Tipo de Plantas";
            this.TiposDePlantasButton.UseVisualStyleBackColor = true;
            this.TiposDePlantasButton.Click += new System.EventHandler(this.TiposDePlantasButton_Click);
            // 
            // TiposDeEnvasesButton
            // 
            this.TiposDeEnvasesButton.Location = new System.Drawing.Point(202, 75);
            this.TiposDeEnvasesButton.Name = "TiposDeEnvasesButton";
            this.TiposDeEnvasesButton.Size = new System.Drawing.Size(143, 72);
            this.TiposDeEnvasesButton.TabIndex = 0;
            this.TiposDeEnvasesButton.Text = "Tipos de Envases";
            this.TiposDeEnvasesButton.UseVisualStyleBackColor = true;
            // 
            // PlantasButton
            // 
            this.PlantasButton.Location = new System.Drawing.Point(351, 75);
            this.PlantasButton.Name = "PlantasButton";
            this.PlantasButton.Size = new System.Drawing.Size(143, 72);
            this.PlantasButton.TabIndex = 0;
            this.PlantasButton.Text = "Plantas";
            this.PlantasButton.UseVisualStyleBackColor = true;
            this.PlantasButton.Click += new System.EventHandler(this.PlantasButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(699, 371);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(89, 48);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.PlantasButton);
            this.Controls.Add(this.TiposDeEnvasesButton);
            this.Controls.Add(this.TiposDePlantasButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TiposDePlantasButton;
        private System.Windows.Forms.Button TiposDeEnvasesButton;
        private System.Windows.Forms.Button PlantasButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}

