namespace Celikoor_Tixycket
{
    partial class FormLoginKonsumen
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
            this.labelLoginPanel = new System.Windows.Forms.Label();
            this.linkLabelCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoginPanel
            // 
            this.labelLoginPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.labelLoginPanel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginPanel.Location = new System.Drawing.Point(0, -4);
            this.labelLoginPanel.Name = "labelLoginPanel";
            this.labelLoginPanel.Size = new System.Drawing.Size(476, 548);
            this.labelLoginPanel.TabIndex = 6;
            this.labelLoginPanel.Text = "LOGIN\r\nCONSUMEN\r\n";
            this.labelLoginPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabelCreateAnAccount
            // 
            this.linkLabelCreateAnAccount.AutoSize = true;
            this.linkLabelCreateAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAnAccount.LinkColor = System.Drawing.Color.BlueViolet;
            this.linkLabelCreateAnAccount.Location = new System.Drawing.Point(700, 455);
            this.linkLabelCreateAnAccount.Name = "linkLabelCreateAnAccount";
            this.linkLabelCreateAnAccount.Size = new System.Drawing.Size(250, 29);
            this.linkLabelCreateAnAccount.TabIndex = 21;
            this.linkLabelCreateAnAccount.TabStop = true;
            this.linkLabelCreateAnAccount.Text = "New User? Click Here";
            this.linkLabelCreateAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAnAccount_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(769, 397);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(123, 40);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(769, 273);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(312, 34);
            this.textBoxPasswordLogin.TabIndex = 19;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(769, 207);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(312, 34);
            this.textBoxUsernameLogin.TabIndex = 18;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(556, 274);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(154, 29);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(556, 208);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(158, 29);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username:";
            // 
            // FormLoginKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1146, 540);
            this.Controls.Add(this.linkLabelCreateAnAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLoginPanel);
            this.Name = "FormLoginKonsumen";
            this.Text = "LOGIN KONSUMEN";
            this.Load += new System.EventHandler(this.FormLoginKonsumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLoginPanel;
        private System.Windows.Forms.LinkLabel linkLabelCreateAnAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
    }
}