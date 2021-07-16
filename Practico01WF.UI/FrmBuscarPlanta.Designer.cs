
namespace Practico01WF.UI
{
    partial class FrmBuscarPlanta
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
            this.TipoDeEnvaseComboBox = new System.Windows.Forms.ComboBox();
            this.TipoDePlantaComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoDePlantaRadioButton = new System.Windows.Forms.RadioButton();
            this.TipoDeEnvaseRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TipoDeEnvaseComboBox
            // 
            this.TipoDeEnvaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeEnvaseComboBox.Enabled = false;
            this.TipoDeEnvaseComboBox.FormattingEnabled = true;
            this.TipoDeEnvaseComboBox.Location = new System.Drawing.Point(190, 84);
            this.TipoDeEnvaseComboBox.Name = "TipoDeEnvaseComboBox";
            this.TipoDeEnvaseComboBox.Size = new System.Drawing.Size(247, 21);
            this.TipoDeEnvaseComboBox.TabIndex = 31;
            this.TipoDeEnvaseComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoDeEnvaseComboBox_SelectedIndexChanged);
            // 
            // TipoDePlantaComboBox
            // 
            this.TipoDePlantaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDePlantaComboBox.Enabled = false;
            this.TipoDePlantaComboBox.FormattingEnabled = true;
            this.TipoDePlantaComboBox.Location = new System.Drawing.Point(190, 38);
            this.TipoDePlantaComboBox.Name = "TipoDePlantaComboBox";
            this.TipoDePlantaComboBox.Size = new System.Drawing.Size(247, 21);
            this.TipoDePlantaComboBox.TabIndex = 32;
            this.TipoDePlantaComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoDePlantaComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::Practico01WF.UI.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(452, 141);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::Practico01WF.UI.Properties.Resources.Guardar;
            this.OkButton.Location = new System.Drawing.Point(75, 141);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 30;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo de Planta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de Envase:";
            // 
            // TipoDePlantaRadioButton
            // 
            this.TipoDePlantaRadioButton.AutoSize = true;
            this.TipoDePlantaRadioButton.Location = new System.Drawing.Point(43, 41);
            this.TipoDePlantaRadioButton.Name = "TipoDePlantaRadioButton";
            this.TipoDePlantaRadioButton.Size = new System.Drawing.Size(14, 13);
            this.TipoDePlantaRadioButton.TabIndex = 33;
            this.TipoDePlantaRadioButton.TabStop = true;
            this.TipoDePlantaRadioButton.UseVisualStyleBackColor = true;
            this.TipoDePlantaRadioButton.CheckedChanged += new System.EventHandler(this.TipoDePlantaRadioButton_CheckedChanged);
            // 
            // TipoDeEnvaseRadioButton
            // 
            this.TipoDeEnvaseRadioButton.AutoSize = true;
            this.TipoDeEnvaseRadioButton.Location = new System.Drawing.Point(43, 87);
            this.TipoDeEnvaseRadioButton.Name = "TipoDeEnvaseRadioButton";
            this.TipoDeEnvaseRadioButton.Size = new System.Drawing.Size(14, 13);
            this.TipoDeEnvaseRadioButton.TabIndex = 33;
            this.TipoDeEnvaseRadioButton.TabStop = true;
            this.TipoDeEnvaseRadioButton.UseVisualStyleBackColor = true;
            this.TipoDeEnvaseRadioButton.CheckedChanged += new System.EventHandler(this.TipoDeEnvaseRadioButton_CheckedChanged);
            // 
            // FrmBuscarPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 228);
            this.Controls.Add(this.TipoDeEnvaseRadioButton);
            this.Controls.Add(this.TipoDePlantaRadioButton);
            this.Controls.Add(this.TipoDeEnvaseComboBox);
            this.Controls.Add(this.TipoDePlantaComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(625, 267);
            this.MinimumSize = new System.Drawing.Size(625, 267);
            this.Name = "FrmBuscarPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarPlanta";
            this.Load += new System.EventHandler(this.FrmBuscarPlanta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoDeEnvaseComboBox;
        private System.Windows.Forms.ComboBox TipoDePlantaComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TipoDePlantaRadioButton;
        private System.Windows.Forms.RadioButton TipoDeEnvaseRadioButton;
    }
}