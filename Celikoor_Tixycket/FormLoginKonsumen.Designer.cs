using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.linkLabelCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.timerImageMoving = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pageIndicator4 = new System.Windows.Forms.Button();
            this.pageIndicator3 = new System.Windows.Forms.Button();
            this.pageIndicator2 = new System.Windows.Forms.Button();
            this.pageIndicator1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCreateAnAccount
            // 
            this.linkLabelCreateAnAccount.AutoSize = true;
            this.linkLabelCreateAnAccount.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAnAccount.LinkColor = System.Drawing.Color.Tan;
            this.linkLabelCreateAnAccount.Location = new System.Drawing.Point(849, 567);
            this.linkLabelCreateAnAccount.Name = "linkLabelCreateAnAccount";
            this.linkLabelCreateAnAccount.Size = new System.Drawing.Size(71, 20);
            this.linkLabelCreateAnAccount.TabIndex = 21;
            this.linkLabelCreateAnAccount.TabStop = true;
            this.linkLabelCreateAnAccount.Text = "Click Here";
            this.linkLabelCreateAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAnAccount_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Tan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(635, 503);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(339, 39);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(635, 370);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(337, 30);
            this.textBoxPasswordLogin.TabIndex = 12;
            this.textBoxPasswordLogin.Text = "Password";
            this.textBoxPasswordLogin.WordWrap = false;
            this.textBoxPasswordLogin.Click += new System.EventHandler(this.textBoxPasswordLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(631, 344);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(122, 25);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(631, 265);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(124, 25);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(663, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "WELCOME BACK";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Enabled = false;
            this.labelTo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.Tan;
            this.labelTo.Location = new System.Drawing.Point(747, 120);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(30, 22);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "to";
            // 
            // timerImageMoving
            // 
            this.timerImageMoving.Enabled = true;
            this.timerImageMoving.Interval = 4000;
            this.timerImageMoving.Tick += new System.EventHandler(this.timerImageMoving_Tick);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.Color.LightSlateGray;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(624, 442);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(131, 20);
            this.checkBoxRememberMe.TabIndex = 26;
            this.checkBoxRememberMe.Text = "Remember me?";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Click += new System.EventHandler(this.checkBoxRememberMe_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ForgotPassword.Location = new System.Drawing.Point(866, 443);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(121, 16);
            this.ForgotPassword.TabIndex = 27;
            this.ForgotPassword.Text = "Forgot Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(687, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Don\'t have an account?";
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.Page1;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.pageIndicator4);
            this.panelImage.Controls.Add(this.pageIndicator3);
            this.panelImage.Controls.Add(this.pageIndicator2);
            this.panelImage.Controls.Add(this.pageIndicator1);
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(503, 683);
            this.panelImage.TabIndex = 25;
            this.panelImage.Click += new System.EventHandler(this.panelImage_Click);
            // 
            // pageIndicator4
            // 
            this.pageIndicator4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator4.Enabled = false;
            this.pageIndicator4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator4.Location = new System.Drawing.Point(285, 651);
            this.pageIndicator4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageIndicator4.Name = "pageIndicator4";
            this.pageIndicator4.Size = new System.Drawing.Size(23, 10);
            this.pageIndicator4.TabIndex = 32;
            this.pageIndicator4.UseVisualStyleBackColor = false;
            // 
            // pageIndicator3
            // 
            this.pageIndicator3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator3.Enabled = false;
            this.pageIndicator3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator3.Location = new System.Drawing.Point(256, 651);
            this.pageIndicator3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageIndicator3.Name = "pageIndicator3";
            this.pageIndicator3.Size = new System.Drawing.Size(23, 10);
            this.pageIndicator3.TabIndex = 31;
            this.pageIndicator3.UseVisualStyleBackColor = false;
            // 
            // pageIndicator2
            // 
            this.pageIndicator2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator2.Enabled = false;
            this.pageIndicator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator2.Location = new System.Drawing.Point(227, 651);
            this.pageIndicator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageIndicator2.Name = "pageIndicator2";
            this.pageIndicator2.Size = new System.Drawing.Size(23, 10);
            this.pageIndicator2.TabIndex = 30;
            this.pageIndicator2.UseVisualStyleBackColor = false;
            // 
            // pageIndicator1
            // 
            this.pageIndicator1.BackColor = System.Drawing.Color.DarkOrange;
            this.pageIndicator1.Enabled = false;
            this.pageIndicator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator1.ForeColor = System.Drawing.Color.DarkOrange;
            this.pageIndicator1.Location = new System.Drawing.Point(198, 651);
            this.pageIndicator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageIndicator1.Name = "pageIndicator1";
            this.pageIndicator1.Size = new System.Drawing.Size(23, 10);
            this.pageIndicator1.TabIndex = 29;
            this.pageIndicator1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(659, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 80);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(635, 291);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(337, 30);
            this.textBoxUsernameLogin.TabIndex = 1;
            this.textBoxUsernameLogin.Text = "Username";
            this.textBoxUsernameLogin.Click += new System.EventHandler(this.textBoxUsernameLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // FormLoginKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1087, 680);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCreateAnAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLoginKonsumen";
            this.Text = "LOGIN KONSUMEN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginKonsumen_FormClosing);
            this.Load += new System.EventHandler(this.FormLoginKonsumen_Load);
            this.Click += new System.EventHandler(this.FormLoginKonsumen_Click);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelCreateAnAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Timer timerImageMoving;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label ForgotPassword;
        private System.Windows.Forms.Label label2;
        private Button pageIndicator4;
        private Button pageIndicator3;
        private Button pageIndicator2;
        private Button pageIndicator1;
        private Timer timer1;
    }
}