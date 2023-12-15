namespace Celikoor_Tixycket
{
    partial class FormProfile
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
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelNoTelp = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelFotoProfile = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelProfile
            // 
            this.labelProfile.BackColor = System.Drawing.Color.Tan;
            this.labelProfile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Transparent;
            this.labelProfile.Location = new System.Drawing.Point(90, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(424, 62);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "PROFILE";
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.BurlyWood;
            this.labelNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.White;
            this.labelNama.Location = new System.Drawing.Point(56, 380);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(164, 36);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "labelNama";
            this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.BurlyWood;
            this.labelUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(56, 444);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(213, 36);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "labelUsername";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoTelp
            // 
            this.labelNoTelp.AutoSize = true;
            this.labelNoTelp.BackColor = System.Drawing.Color.BurlyWood;
            this.labelNoTelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoTelp.ForeColor = System.Drawing.Color.White;
            this.labelNoTelp.Location = new System.Drawing.Point(349, 444);
            this.labelNoTelp.Name = "labelNoTelp";
            this.labelNoTelp.Size = new System.Drawing.Size(175, 36);
            this.labelNoTelp.TabIndex = 2;
            this.labelNoTelp.Text = "labelNoTelp";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tan;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(206, 521);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 58);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.BurlyWood;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(349, 380);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(151, 36);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "labelEmail";
            // 
            // panelFotoProfile
            // 
            this.panelFotoProfile.BackColor = System.Drawing.Color.PeachPuff;
            this.panelFotoProfile.Location = new System.Drawing.Point(172, 89);
            this.panelFotoProfile.Name = "panelFotoProfile";
            this.panelFotoProfile.Size = new System.Drawing.Size(254, 244);
            this.panelFotoProfile.TabIndex = 4;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 610);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panelFotoProfile);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.labelNoTelp);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelNama);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelNoTelp;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelFotoProfile;
    }
}