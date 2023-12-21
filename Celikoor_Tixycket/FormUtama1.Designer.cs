namespace Celikoor_Tixycket
{
    partial class FormUtama1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama1));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelLogoApp = new System.Windows.Forms.Panel();
            this.buttonLogInOut = new System.Windows.Forms.Button();
            this.labelLoginSebagai = new System.Windows.Forms.Label();
            this.buttonMaster = new System.Windows.Forms.Button();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.buttonKelompok = new System.Windows.Forms.Button();
            this.buttonPegawai = new System.Windows.Forms.Button();
            this.buttonKonsumen = new System.Windows.Forms.Button();
            this.buttonAktors = new System.Windows.Forms.Button();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonJenisStudio = new System.Windows.Forms.Button();
            this.buttonStudio = new System.Windows.Forms.Button();
            this.buttonCinema = new System.Windows.Forms.Button();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.buttonLaporan = new System.Windows.Forms.Button();
            this.buttonPencatatanKedatangan = new System.Windows.Forms.Button();
            this.buttonPenjadwalanFilm = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            this.panelLogoApp.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.panelSystem.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelForm.Controls.Add(this.button1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(250, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(863, 632);
            this.panelForm.TabIndex = 1;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // panelLogoApp
            // 
            this.panelLogoApp.Controls.Add(this.buttonLogInOut);
            this.panelLogoApp.Controls.Add(this.labelLoginSebagai);
            this.panelLogoApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoApp.Location = new System.Drawing.Point(0, 0);
            this.panelLogoApp.Name = "panelLogoApp";
            this.panelLogoApp.Size = new System.Drawing.Size(229, 94);
            this.panelLogoApp.TabIndex = 0;
            // 
            // buttonLogInOut
            // 
            this.buttonLogInOut.BackColor = System.Drawing.Color.Khaki;
            this.buttonLogInOut.Font = new System.Drawing.Font("Verdana", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogInOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogInOut.Location = new System.Drawing.Point(34, 50);
            this.buttonLogInOut.Name = "buttonLogInOut";
            this.buttonLogInOut.Size = new System.Drawing.Size(139, 29);
            this.buttonLogInOut.TabIndex = 0;
            this.buttonLogInOut.Text = "LOGIN";
            this.buttonLogInOut.UseVisualStyleBackColor = false;
            this.buttonLogInOut.Click += new System.EventHandler(this.buttonLogInOut_Click);
            // 
            // labelLoginSebagai
            // 
            this.labelLoginSebagai.AutoSize = true;
            this.labelLoginSebagai.Location = new System.Drawing.Point(30, 17);
            this.labelLoginSebagai.Name = "labelLoginSebagai";
            this.labelLoginSebagai.Size = new System.Drawing.Size(161, 20);
            this.labelLoginSebagai.TabIndex = 1;
            this.labelLoginSebagai.Text = "Logged In As : None";
            // 
            // buttonMaster
            // 
            this.buttonMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMaster.FlatAppearance.BorderSize = 0;
            this.buttonMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaster.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMaster.Location = new System.Drawing.Point(0, 94);
            this.buttonMaster.Name = "buttonMaster";
            this.buttonMaster.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMaster.Size = new System.Drawing.Size(229, 45);
            this.buttonMaster.TabIndex = 1;
            this.buttonMaster.Text = "Master";
            this.buttonMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaster.UseVisualStyleBackColor = true;
            this.buttonMaster.Click += new System.EventHandler(this.buttonMaster_Click);
            // 
            // panelMaster
            // 
            this.panelMaster.BackColor = System.Drawing.Color.SandyBrown;
            this.panelMaster.Controls.Add(this.buttonKelompok);
            this.panelMaster.Controls.Add(this.buttonPegawai);
            this.panelMaster.Controls.Add(this.buttonKonsumen);
            this.panelMaster.Controls.Add(this.buttonAktors);
            this.panelMaster.Controls.Add(this.buttonGenre);
            this.panelMaster.Controls.Add(this.buttonJenisStudio);
            this.panelMaster.Controls.Add(this.buttonStudio);
            this.panelMaster.Controls.Add(this.buttonCinema);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 139);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(229, 325);
            this.panelMaster.TabIndex = 2;
            // 
            // buttonKelompok
            // 
            this.buttonKelompok.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelompok.ForeColor = System.Drawing.Color.White;
            this.buttonKelompok.Location = new System.Drawing.Point(0, 280);
            this.buttonKelompok.Name = "buttonKelompok";
            this.buttonKelompok.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonKelompok.Size = new System.Drawing.Size(229, 40);
            this.buttonKelompok.TabIndex = 7;
            this.buttonKelompok.Text = "Kelompok";
            this.buttonKelompok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelompok.UseVisualStyleBackColor = true;
            this.buttonKelompok.Click += new System.EventHandler(this.buttonKelompok_Click);
            // 
            // buttonPegawai
            // 
            this.buttonPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPegawai.ForeColor = System.Drawing.Color.White;
            this.buttonPegawai.Location = new System.Drawing.Point(0, 240);
            this.buttonPegawai.Name = "buttonPegawai";
            this.buttonPegawai.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPegawai.Size = new System.Drawing.Size(229, 40);
            this.buttonPegawai.TabIndex = 6;
            this.buttonPegawai.Text = "Pegawai";
            this.buttonPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPegawai.UseVisualStyleBackColor = true;
            this.buttonPegawai.Click += new System.EventHandler(this.buttonPegawai_Click);
            // 
            // buttonKonsumen
            // 
            this.buttonKonsumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKonsumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonsumen.ForeColor = System.Drawing.Color.White;
            this.buttonKonsumen.Location = new System.Drawing.Point(0, 200);
            this.buttonKonsumen.Name = "buttonKonsumen";
            this.buttonKonsumen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonKonsumen.Size = new System.Drawing.Size(229, 40);
            this.buttonKonsumen.TabIndex = 5;
            this.buttonKonsumen.Text = "Konsumen";
            this.buttonKonsumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKonsumen.UseVisualStyleBackColor = true;
            this.buttonKonsumen.Click += new System.EventHandler(this.buttonKonsumen_Click);
            // 
            // buttonAktors
            // 
            this.buttonAktors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAktors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktors.ForeColor = System.Drawing.Color.White;
            this.buttonAktors.Location = new System.Drawing.Point(0, 160);
            this.buttonAktors.Name = "buttonAktors";
            this.buttonAktors.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAktors.Size = new System.Drawing.Size(229, 40);
            this.buttonAktors.TabIndex = 4;
            this.buttonAktors.Text = "Aktors";
            this.buttonAktors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAktors.UseVisualStyleBackColor = true;
            this.buttonAktors.Click += new System.EventHandler(this.buttonAktors_Click);
            // 
            // buttonGenre
            // 
            this.buttonGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenre.ForeColor = System.Drawing.Color.White;
            this.buttonGenre.Location = new System.Drawing.Point(0, 120);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonGenre.Size = new System.Drawing.Size(229, 40);
            this.buttonGenre.TabIndex = 3;
            this.buttonGenre.Text = "Genre";
            this.buttonGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonJenisStudio
            // 
            this.buttonJenisStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJenisStudio.ForeColor = System.Drawing.Color.White;
            this.buttonJenisStudio.Location = new System.Drawing.Point(0, 80);
            this.buttonJenisStudio.Name = "buttonJenisStudio";
            this.buttonJenisStudio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonJenisStudio.Size = new System.Drawing.Size(229, 40);
            this.buttonJenisStudio.TabIndex = 2;
            this.buttonJenisStudio.Text = "Jenis Studio";
            this.buttonJenisStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJenisStudio.UseVisualStyleBackColor = true;
            this.buttonJenisStudio.Click += new System.EventHandler(this.buttonJenisStudio_Click);
            // 
            // buttonStudio
            // 
            this.buttonStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudio.ForeColor = System.Drawing.Color.White;
            this.buttonStudio.Location = new System.Drawing.Point(0, 40);
            this.buttonStudio.Name = "buttonStudio";
            this.buttonStudio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStudio.Size = new System.Drawing.Size(229, 40);
            this.buttonStudio.TabIndex = 1;
            this.buttonStudio.Text = "Studio";
            this.buttonStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudio.UseVisualStyleBackColor = true;
            this.buttonStudio.Click += new System.EventHandler(this.buttonStudio_Click);
            // 
            // buttonCinema
            // 
            this.buttonCinema.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCinema.ForeColor = System.Drawing.Color.White;
            this.buttonCinema.Location = new System.Drawing.Point(0, 0);
            this.buttonCinema.Name = "buttonCinema";
            this.buttonCinema.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCinema.Size = new System.Drawing.Size(229, 40);
            this.buttonCinema.TabIndex = 0;
            this.buttonCinema.Text = "Cinema";
            this.buttonCinema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCinema.UseVisualStyleBackColor = true;
            this.buttonCinema.Click += new System.EventHandler(this.buttonCinema_Click);
            // 
            // buttonSystem
            // 
            this.buttonSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSystem.FlatAppearance.BorderSize = 0;
            this.buttonSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSystem.Location = new System.Drawing.Point(0, 464);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSystem.Size = new System.Drawing.Size(229, 45);
            this.buttonSystem.TabIndex = 3;
            this.buttonSystem.Text = "System";
            this.buttonSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSystem.UseVisualStyleBackColor = true;
            this.buttonSystem.Click += new System.EventHandler(this.buttonSystem_Click);
            // 
            // panelSystem
            // 
            this.panelSystem.BackColor = System.Drawing.Color.SandyBrown;
            this.panelSystem.Controls.Add(this.buttonLaporan);
            this.panelSystem.Controls.Add(this.buttonPencatatanKedatangan);
            this.panelSystem.Controls.Add(this.buttonPenjadwalanFilm);
            this.panelSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSystem.Location = new System.Drawing.Point(0, 509);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(229, 128);
            this.panelSystem.TabIndex = 4;
            this.panelSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSystem_Paint);
            // 
            // buttonLaporan
            // 
            this.buttonLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaporan.ForeColor = System.Drawing.Color.White;
            this.buttonLaporan.Location = new System.Drawing.Point(0, 80);
            this.buttonLaporan.Name = "buttonLaporan";
            this.buttonLaporan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLaporan.Size = new System.Drawing.Size(229, 40);
            this.buttonLaporan.TabIndex = 7;
            this.buttonLaporan.Text = "Laporan";
            this.buttonLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaporan.UseVisualStyleBackColor = true;
            this.buttonLaporan.Click += new System.EventHandler(this.buttonLaporan_Click);
            // 
            // buttonPencatatanKedatangan
            // 
            this.buttonPencatatanKedatangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPencatatanKedatangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencatatanKedatangan.ForeColor = System.Drawing.Color.White;
            this.buttonPencatatanKedatangan.Location = new System.Drawing.Point(0, 40);
            this.buttonPencatatanKedatangan.Name = "buttonPencatatanKedatangan";
            this.buttonPencatatanKedatangan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPencatatanKedatangan.Size = new System.Drawing.Size(229, 40);
            this.buttonPencatatanKedatangan.TabIndex = 6;
            this.buttonPencatatanKedatangan.Text = "Catat Kedatangan";
            this.buttonPencatatanKedatangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPencatatanKedatangan.UseVisualStyleBackColor = true;
            this.buttonPencatatanKedatangan.Click += new System.EventHandler(this.buttonPencatatanKedatangan_Click);
            // 
            // buttonPenjadwalanFilm
            // 
            this.buttonPenjadwalanFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPenjadwalanFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPenjadwalanFilm.ForeColor = System.Drawing.Color.White;
            this.buttonPenjadwalanFilm.Location = new System.Drawing.Point(0, 0);
            this.buttonPenjadwalanFilm.Name = "buttonPenjadwalanFilm";
            this.buttonPenjadwalanFilm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPenjadwalanFilm.Size = new System.Drawing.Size(229, 40);
            this.buttonPenjadwalanFilm.TabIndex = 5;
            this.buttonPenjadwalanFilm.Text = "Penjadwalan Film";
            this.buttonPenjadwalanFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPenjadwalanFilm.UseVisualStyleBackColor = true;
            this.buttonPenjadwalanFilm.Click += new System.EventHandler(this.buttonPenjadwalanFilm_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTransaction.FlatAppearance.BorderSize = 0;
            this.buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaction.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTransaction.Location = new System.Drawing.Point(0, 637);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTransaction.Size = new System.Drawing.Size(229, 45);
            this.buttonTransaction.TabIndex = 5;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Peru;
            this.panelMenu.Controls.Add(this.buttonTransaction);
            this.panelMenu.Controls.Add(this.panelSystem);
            this.panelMenu.Controls.Add(this.buttonSystem);
            this.panelMenu.Controls.Add(this.panelMaster);
            this.panelMenu.Controls.Add(this.buttonMaster);
            this.panelMenu.Controls.Add(this.panelLogoApp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 632);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUtama1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1113, 632);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUtama1";
            this.Text = "TIXIE";
            this.Load += new System.EventHandler(this.FormUtama1_Load);
            this.panelForm.ResumeLayout(false);
            this.panelLogoApp.ResumeLayout(false);
            this.panelLogoApp.PerformLayout();
            this.panelMaster.ResumeLayout(false);
            this.panelSystem.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelLogoApp;
        private System.Windows.Forms.Button buttonMaster;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Button buttonKelompok;
        private System.Windows.Forms.Button buttonPegawai;
        private System.Windows.Forms.Button buttonKonsumen;
        private System.Windows.Forms.Button buttonAktors;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonJenisStudio;
        private System.Windows.Forms.Button buttonStudio;
        private System.Windows.Forms.Button buttonCinema;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Button buttonPencatatanKedatangan;
        private System.Windows.Forms.Button buttonPenjadwalanFilm;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLogInOut;
        private System.Windows.Forms.Label labelLoginSebagai;
        private System.Windows.Forms.Button button1;
    }
}