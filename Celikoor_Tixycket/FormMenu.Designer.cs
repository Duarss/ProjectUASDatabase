namespace Celikoor_Tixycket
{
    partial class FormMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripFormMenu = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.filmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStripFormMenu
            // 
            this.menuStripFormMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripFormMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripFormMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem});
            this.menuStripFormMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormMenu.Name = "menuStripFormMenu";
            this.menuStripFormMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripFormMenu.Size = new System.Drawing.Size(1125, 46);
            this.menuStripFormMenu.TabIndex = 1;
            this.menuStripFormMenu.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konsumenToolStripMenuItem,
            this.operatorToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.filmToolStripMenuItem1,
            this.aktorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.karyawanToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(118, 42);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // konsumenToolStripMenuItem
            // 
            this.konsumenToolStripMenuItem.Name = "konsumenToolStripMenuItem";
            this.konsumenToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.konsumenToolStripMenuItem.Text = "Konsumen";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.operatorToolStripMenuItem.Text = "Cinema";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.filmToolStripMenuItem.Text = "Genre";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(267, 6);
            // 
            // filmToolStripMenuItem1
            // 
            this.filmToolStripMenuItem1.Name = "filmToolStripMenuItem1";
            this.filmToolStripMenuItem1.Size = new System.Drawing.Size(270, 46);
            this.filmToolStripMenuItem1.Text = "Film";
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            // 
            // aktorToolStripMenuItem
            // 
            this.aktorToolStripMenuItem.Name = "aktorToolStripMenuItem";
            this.aktorToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.aktorToolStripMenuItem.Text = "Aktor";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 714);
            this.Controls.Add(this.menuStripFormMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripFormMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripFormMenu.ResumeLayout(false);
            this.menuStripFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStripFormMenu;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
    }
}

