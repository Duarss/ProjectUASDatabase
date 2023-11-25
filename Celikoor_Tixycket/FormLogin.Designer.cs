using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.linkLabelCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
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
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCreateAnAccount
            // 
            this.linkLabelCreateAnAccount.AutoSize = true;
            this.linkLabelCreateAnAccount.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAnAccount.LinkColor = System.Drawing.Color.Peru;
            this.linkLabelCreateAnAccount.Location = new System.Drawing.Point(966, 729);
            this.linkLabelCreateAnAccount.Name = "linkLabelCreateAnAccount";
            this.linkLabelCreateAnAccount.Size = new System.Drawing.Size(82, 22);
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
            this.buttonLogin.Location = new System.Drawing.Point(712, 658);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(381, 49);
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
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(714, 462);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(379, 35);
            this.textBoxPasswordLogin.TabIndex = 12;
            this.textBoxPasswordLogin.Text = "Enter your password";
            this.textBoxPasswordLogin.WordWrap = false;
            this.textBoxPasswordLogin.Click += new System.EventHandler(this.textBoxPasswordLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(746, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "WELCOME BACK";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Enabled = false;
            this.labelTo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.Tan;
            this.labelTo.Location = new System.Drawing.Point(840, 150);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(37, 26);
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
            this.checkBoxRememberMe.Location = new System.Drawing.Point(700, 592);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(155, 23);
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
            this.ForgotPassword.Location = new System.Drawing.Point(972, 594);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(151, 19);
            this.ForgotPassword.TabIndex = 27;
            this.ForgotPassword.Text = "Forgot Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(763, 732);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Don\'t have an account?";
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.pageIndicator4);
            this.panelImage.Controls.Add(this.pageIndicator3);
            this.panelImage.Controls.Add(this.pageIndicator2);
            this.panelImage.Controls.Add(this.pageIndicator1);
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(566, 854);
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
            this.pageIndicator4.Location = new System.Drawing.Point(321, 814);
            this.pageIndicator4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator4.Name = "pageIndicator4";
            this.pageIndicator4.Size = new System.Drawing.Size(26, 12);
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
            this.pageIndicator3.Location = new System.Drawing.Point(288, 814);
            this.pageIndicator3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator3.Name = "pageIndicator3";
            this.pageIndicator3.Size = new System.Drawing.Size(26, 12);
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
            this.pageIndicator2.Location = new System.Drawing.Point(255, 814);
            this.pageIndicator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator2.Name = "pageIndicator2";
            this.pageIndicator2.Size = new System.Drawing.Size(26, 12);
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
            this.pageIndicator1.Location = new System.Drawing.Point(223, 814);
            this.pageIndicator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator1.Name = "pageIndicator1";
            this.pageIndicator1.Size = new System.Drawing.Size(26, 12);
            this.pageIndicator1.TabIndex = 29;
            this.pageIndicator1.UseVisualStyleBackColor = false;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.AccessibleDescription = "";
            this.textBoxUsernameLogin.AccessibleName = "";
            this.textBoxUsernameLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(714, 364);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(379, 35);
            this.textBoxUsernameLogin.TabIndex = 1;
            this.textBoxUsernameLogin.Text = "Enter your username";
            this.textBoxUsernameLogin.Click += new System.EventHandler(this.textBoxUsernameLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(710, 430);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(125, 25);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(710, 331);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 25);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(741, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 100);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.BackColor = System.Drawing.Color.FloralWhite;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonKonsumen.Location = new System.Drawing.Point(831, 521);
            this.radioButtonKonsumen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(118, 23);
            this.radioButtonKonsumen.TabIndex = 49;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = false;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAs.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelLoginAs.Location = new System.Drawing.Point(724, 524);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(91, 18);
            this.labelLoginAs.TabIndex = 50;
            this.labelLoginAs.Text = "Login as :";
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.BackColor = System.Drawing.Color.FloralWhite;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonPegawai.Location = new System.Drawing.Point(999, 521);
            this.radioButtonPegawai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(99, 23);
            this.radioButtonPegawai.TabIndex = 51;
            this.radioButtonPegawai.TabStop = true;
            this.radioButtonPegawai.Text = "Pegawai";
            this.radioButtonPegawai.UseVisualStyleBackColor = false;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1223, 850);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.labelLoginAs);
            this.Controls.Add(this.radioButtonKonsumen);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "TIXIE";
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
        private Label labelPassword;
        private Label labelUsername;
        private RadioButton radioButtonKonsumen;
        private Label labelLoginAs;
        private RadioButton radioButtonPegawai;
    }
}