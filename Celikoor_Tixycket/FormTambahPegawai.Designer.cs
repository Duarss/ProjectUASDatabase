namespace Celikoor_Tixycket
{
    partial class FormTambahPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahPegawai));
            this.labelJudul = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelCari = new System.Windows.Forms.Label();
            this.textBoxNamaPegawai = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxIdPegawai = new System.Windows.Forms.TextBox();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsernamePegawai = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordPegawai = new System.Windows.Forms.TextBox();
            this.labelJabatan = new System.Windows.Forms.Label();
            this.comboBoxRolePegawai = new System.Windows.Forms.ComboBox();
            this.textBoxEmailPegawai = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Tan;
            this.labelJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJudul.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.Transparent;
            this.labelJudul.Location = new System.Drawing.Point(137, 31);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(860, 62);
            this.labelJudul.TabIndex = 31;
            this.labelJudul.Text = "TAMBAH PEGAWAI";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Tan;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(814, 592);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(182, 56);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Tan;
            this.buttonKosongi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKosongi.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(469, 592);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(182, 56);
            this.buttonKosongi.TabIndex = 35;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Tan;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(137, 592);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(182, 56);
            this.buttonSimpan.TabIndex = 33;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelCari
            // 
            this.labelCari.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCari.Location = new System.Drawing.Point(276, 199);
            this.labelCari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(210, 56);
            this.labelCari.TabIndex = 19;
            this.labelCari.Text = "Nama Pegawai:";
            this.labelCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNamaPegawai
            // 
            this.textBoxNamaPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaPegawai.Location = new System.Drawing.Point(529, 208);
            this.textBoxNamaPegawai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaPegawai.Name = "textBoxNamaPegawai";
            this.textBoxNamaPegawai.Size = new System.Drawing.Size(302, 36);
            this.textBoxNamaPegawai.TabIndex = 20;
            // 
            // labelId
            // 
            this.labelId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(322, 130);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(164, 56);
            this.labelId.TabIndex = 21;
            this.labelId.Text = "Id Pegawai:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIdPegawai
            // 
            this.textBoxIdPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPegawai.Location = new System.Drawing.Point(529, 140);
            this.textBoxIdPegawai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdPegawai.Name = "textBoxIdPegawai";
            this.textBoxIdPegawai.Size = new System.Drawing.Size(104, 36);
            this.textBoxIdPegawai.TabIndex = 22;
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalLahir.Location = new System.Drawing.Point(394, 269);
            this.labelTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(92, 56);
            this.labelTanggalLahir.TabIndex = 24;
            this.labelTanggalLahir.Text = "Email:";
            this.labelTanggalLahir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(338, 336);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(148, 56);
            this.labelUsername.TabIndex = 29;
            this.labelUsername.Text = "Username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUsernamePegawai
            // 
            this.textBoxUsernamePegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernamePegawai.Location = new System.Drawing.Point(529, 344);
            this.textBoxUsernamePegawai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernamePegawai.Name = "textBoxUsernamePegawai";
            this.textBoxUsernamePegawai.Size = new System.Drawing.Size(302, 36);
            this.textBoxUsernamePegawai.TabIndex = 30;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(338, 402);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(148, 56);
            this.labelPassword.TabIndex = 31;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPasswordPegawai
            // 
            this.textBoxPasswordPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordPegawai.Location = new System.Drawing.Point(529, 411);
            this.textBoxPasswordPegawai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordPegawai.Name = "textBoxPasswordPegawai";
            this.textBoxPasswordPegawai.Size = new System.Drawing.Size(302, 36);
            this.textBoxPasswordPegawai.TabIndex = 32;
            // 
            // labelJabatan
            // 
            this.labelJabatan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJabatan.Location = new System.Drawing.Point(394, 464);
            this.labelJabatan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJabatan.Name = "labelJabatan";
            this.labelJabatan.Size = new System.Drawing.Size(92, 56);
            this.labelJabatan.TabIndex = 35;
            this.labelJabatan.Text = "Role:";
            this.labelJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRolePegawai
            // 
            this.comboBoxRolePegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRolePegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRolePegawai.FormattingEnabled = true;
            this.comboBoxRolePegawai.Items.AddRange(new object[] {
            "Admin",
            "Operator",
            "Kasir"});
            this.comboBoxRolePegawai.Location = new System.Drawing.Point(529, 474);
            this.comboBoxRolePegawai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRolePegawai.Name = "comboBoxRolePegawai";
            this.comboBoxRolePegawai.Size = new System.Drawing.Size(302, 37);
            this.comboBoxRolePegawai.TabIndex = 36;
            // 
            // textBoxEmailPegawai
            // 
            this.textBoxEmailPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailPegawai.Location = new System.Drawing.Point(529, 278);
            this.textBoxEmailPegawai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailPegawai.Name = "textBoxEmailPegawai";
            this.textBoxEmailPegawai.Size = new System.Drawing.Size(302, 36);
            this.textBoxEmailPegawai.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Location = new System.Drawing.Point(137, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 536);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Location = new System.Drawing.Point(986, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 536);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tan;
            this.pictureBox3.Location = new System.Drawing.Point(137, 556);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(860, 12);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // FormTambahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 676);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEmailPegawai);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.comboBoxRolePegawai);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.labelJabatan);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.textBoxPasswordPegawai);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsernamePegawai);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.textBoxNamaPegawai);
            this.Controls.Add(this.textBoxIdPegawai);
            this.Controls.Add(this.labelId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTambahPegawai";
            this.Text = "TIXIE";
            this.Load += new System.EventHandler(this.FormTambahPegawai_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.TextBox textBoxNamaPegawai;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxIdPegawai;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsernamePegawai;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPasswordPegawai;
        private System.Windows.Forms.Label labelJabatan;
        private System.Windows.Forms.ComboBox comboBoxRolePegawai;
        private System.Windows.Forms.TextBox textBoxEmailPegawai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}