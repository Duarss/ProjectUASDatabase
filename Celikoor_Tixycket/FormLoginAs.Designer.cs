namespace Celikoor_Tixycket
{
    partial class FormLoginAs
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
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAs.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelLoginAs.Location = new System.Drawing.Point(303, 69);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(192, 34);
            this.labelLoginAs.TabIndex = 0;
            this.labelLoginAs.Text = "LOGIN AS :";
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonKonsumen.Location = new System.Drawing.Point(94, 194);
            this.radioButtonKonsumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(207, 38);
            this.radioButtonKonsumen.TabIndex = 1;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.radioButtonPegawai.Location = new System.Drawing.Point(508, 194);
            this.radioButtonPegawai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(175, 38);
            this.radioButtonPegawai.TabIndex = 2;
            this.radioButtonPegawai.Text = "Aktor";
            this.radioButtonPegawai.UseVisualStyleBackColor = true;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // FormLoginAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.labelLoginAs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormLoginAs";
            this.Text = "LOGIN AS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginAs_FormClosing);
            this.Load += new System.EventHandler(this.FormLoginAs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginAs;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.RadioButton radioButtonPegawai;
    }
}