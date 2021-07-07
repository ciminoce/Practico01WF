
namespace Practico01WF.UI
{
    partial class FrmPlantaEdit
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlantaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoDePlantaComboBox = new System.Windows.Forms.ComboBox();
            this.TipoDeEnvaseComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::Practico01WF.UI.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(501, 162);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Image = global::Practico01WF.UI.Properties.Resources.Guardar;
            this.OkButton.Location = new System.Drawing.Point(124, 162);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 25;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo de Envase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Planta:";
            // 
            // PlantaTextBox
            // 
            this.PlantaTextBox.Location = new System.Drawing.Point(239, 37);
            this.PlantaTextBox.MaxLength = 100;
            this.PlantaTextBox.Name = "PlantaTextBox";
            this.PlantaTextBox.Size = new System.Drawing.Size(356, 20);
            this.PlantaTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo de Planta:";
            // 
            // TipoDePlantaComboBox
            // 
            this.TipoDePlantaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDePlantaComboBox.FormattingEnabled = true;
            this.TipoDePlantaComboBox.Location = new System.Drawing.Point(239, 66);
            this.TipoDePlantaComboBox.Name = "TipoDePlantaComboBox";
            this.TipoDePlantaComboBox.Size = new System.Drawing.Size(247, 21);
            this.TipoDePlantaComboBox.TabIndex = 26;
            // 
            // TipoDeEnvaseComboBox
            // 
            this.TipoDeEnvaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeEnvaseComboBox.FormattingEnabled = true;
            this.TipoDeEnvaseComboBox.Location = new System.Drawing.Point(239, 99);
            this.TipoDeEnvaseComboBox.Name = "TipoDeEnvaseComboBox";
            this.TipoDeEnvaseComboBox.Size = new System.Drawing.Size(247, 21);
            this.TipoDeEnvaseComboBox.TabIndex = 26;
            // 
            // FrmPlantaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.ControlBox = false;
            this.Controls.Add(this.TipoDeEnvaseComboBox);
            this.Controls.Add(this.TipoDePlantaComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlantaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 286);
            this.MinimumSize = new System.Drawing.Size(816, 286);
            this.Name = "FrmPlantaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlantaEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlantaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoDePlantaComboBox;
        private System.Windows.Forms.ComboBox TipoDeEnvaseComboBox;
    }
}