﻿namespace Celikoor_Tixycket
{
    partial class FormTambahCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahCinema));
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlamatCinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTglDibukaCInema = new System.Windows.Forms.DateTimePicker();
            this.textBoxKotaCinema = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.textBoxNamaCabang = new System.Windows.Forms.TextBox();
            this.labelCari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Tan;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(738, 469);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(162, 44);
            this.buttonKeluar.TabIndex = 39;
            this.buttonKeluar.Text = "EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Tan;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(39, 469);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(162, 44);
            this.buttonTambah.TabIndex = 38;
            this.buttonTambah.Text = "ADD";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tan;
            this.pictureBox3.Location = new System.Drawing.Point(39, 442);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(860, 10);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Location = new System.Drawing.Point(890, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 419);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Location = new System.Drawing.Point(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 419);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 50);
            this.label3.TabIndex = 46;
            this.label3.Text = "ADD CINEMA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAlamatCinema
            // 
            this.textBoxAlamatCinema.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamatCinema.Location = new System.Drawing.Point(382, 184);
            this.textBoxAlamatCinema.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamatCinema.Multiline = true;
            this.textBoxAlamatCinema.Name = "textBoxAlamatCinema";
            this.textBoxAlamatCinema.Size = new System.Drawing.Size(343, 88);
            this.textBoxAlamatCinema.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 44);
            this.label1.TabIndex = 58;
            this.label1.Text = "Date Opened:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerTglDibukaCInema
            // 
            this.dateTimePickerTglDibukaCInema.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTglDibukaCInema.Location = new System.Drawing.Point(382, 295);
            this.dateTimePickerTglDibukaCInema.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTglDibukaCInema.Name = "dateTimePickerTglDibukaCInema";
            this.dateTimePickerTglDibukaCInema.Size = new System.Drawing.Size(372, 32);
            this.dateTimePickerTglDibukaCInema.TabIndex = 57;
            // 
            // textBoxKotaCinema
            // 
            this.textBoxKotaCinema.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKotaCinema.Location = new System.Drawing.Point(382, 353);
            this.textBoxKotaCinema.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKotaCinema.Name = "textBoxKotaCinema";
            this.textBoxKotaCinema.Size = new System.Drawing.Size(343, 32);
            this.textBoxKotaCinema.TabIndex = 56;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(231, 345);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(132, 44);
            this.labelPassword.TabIndex = 55;
            this.labelPassword.Text = "City:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalLahir.Location = new System.Drawing.Point(194, 177);
            this.labelTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(169, 44);
            this.labelTanggalLahir.TabIndex = 54;
            this.labelTanggalLahir.Text = "Address:";
            this.labelTanggalLahir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNamaCabang
            // 
            this.textBoxNamaCabang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaCabang.Location = new System.Drawing.Point(382, 129);
            this.textBoxNamaCabang.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaCabang.Name = "textBoxNamaCabang";
            this.textBoxNamaCabang.Size = new System.Drawing.Size(343, 32);
            this.textBoxNamaCabang.TabIndex = 51;
            this.textBoxNamaCabang.Click += new System.EventHandler(this.textBoxNamaCabang_Click);
            this.textBoxNamaCabang.TextChanged += new System.EventHandler(this.textBoxNamaCabang_TextChanged);
            // 
            // labelCari
            // 
            this.labelCari.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCari.Location = new System.Drawing.Point(176, 122);
            this.labelCari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(187, 44);
            this.labelCari.TabIndex = 50;
            this.labelCari.Text = "Cinema Name:";
            this.labelCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormTambahCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 530);
            this.Controls.Add(this.textBoxAlamatCinema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTglDibukaCInema);
            this.Controls.Add(this.textBoxKotaCinema);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.textBoxNamaCabang);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTambahCinema";
            this.Text = "TIXIE";
            this.Load += new System.EventHandler(this.FormTambahCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlamatCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglDibukaCInema;
        private System.Windows.Forms.TextBox textBoxKotaCinema;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.TextBox textBoxNamaCabang;
        private System.Windows.Forms.Label labelCari;
    }
}