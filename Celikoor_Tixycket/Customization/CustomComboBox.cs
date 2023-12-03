using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace Celikoor_Tixycket.Customization
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class CustomComboBox : UserControl
    {
        #region data member
        private Color backColor = Color.White;
        private Color iconColor = Color.BurlyWood;
        private Color listBackColor = Color.FromArgb(230, 288, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.BurlyWood;
        private int borderSize = 1;
        #endregion

        #region properties
        public new Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                labelCustom.BackColor = backColor;
                buttonIcon.BackColor = backColor;
            }
        }
        public Color IconColor
        {
            get
            {
                return iconColor;
            }

            set
            {
                iconColor = value;
                buttonIcon.Invalidate();
            }
        }
        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }

            set
            {
                listBackColor = value;
                comboBoxCustom.BackColor = listBackColor;
            }
        }
        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }

            set
            {
                listTextColor = value;
                comboBoxCustom.ForeColor = listTextColor;
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                labelCustom.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                labelCustom.Font = value;
                comboBoxCustom.Font = value;
            }
        }

        public string Texts
        {
            get
            {
                return labelCustom.Text;
            }

            set
            {
                labelCustom.Text = value;
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return comboBoxCustom.DropDownStyle;
            }

            set
            {
                if (comboBoxCustom.DropDownStyle != ComboBoxStyle.Simple)
                {
                    comboBoxCustom.DropDownStyle = value;
                }
            }
        }
        #endregion

        #region items
        private Button buttonIcon;
        private ComboBox comboBoxCustom;
        private Label labelCustom;
        #endregion

        #region events
        public event EventHandler OnSelectedIndexChanged;
        #endregion

        #region data
        #endregion

        #region constructor
        public CustomComboBox()
        {
            comboBoxCustom = new ComboBox();
            labelCustom = new Label();
            buttonIcon = new Button();
            this.SuspendLayout();

            comboBoxCustom.BackColor = listBackColor;
            comboBoxCustom.Font = new Font(this.Font.Name, 10F);
            comboBoxCustom.ForeColor = listTextColor;
            comboBoxCustom.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboBoxCustom.TextChanged += new EventHandler(ComboBox_TextChanged);

            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;
            buttonIcon.Click += new EventHandler(Icon_Click);
            buttonIcon.Paint += new PaintEventHandler(Icon_Paint);

            labelCustom.Dock = DockStyle.Fill;
            labelCustom.AutoSize = false;
            labelCustom.BackColor = backColor;
            labelCustom.TextAlign = ContentAlignment.MiddleLeft;
            labelCustom.Padding = new Padding(8, 0, 0, 0);
            labelCustom.Font = new Font(this.Font.Name, 10F);
            labelCustom.Click += new EventHandler(Surface_Click);
            labelCustom.MouseEnter += new EventHandler(Surface_MouseEnter);
            labelCustom.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(labelCustom);
            this.Controls.Add(buttonIcon);
            this.Controls.Add(comboBoxCustom);
            this.MinimumSize = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }

        #endregion

        #region method
        //event methods
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            labelCustom.Text = comboBoxCustom.Text;
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelCustom.Text = comboBoxCustom.Text;
        }
        private void Icon_Click(object sender, EventArgs e)
        {
            comboBoxCustom.Select();
            comboBoxCustom.DroppedDown = true;
        }
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((buttonIcon.Width - iconWidth) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            comboBoxCustom.Select();
            if (comboBoxCustom.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                comboBoxCustom.DroppedDown = true;
            }
        }

        //private methods
        private void AdjustComboBoxDimensions()
        {
            comboBoxCustom.Width = labelCustom.Width;
            comboBoxCustom.Location = new Point()
            {
                X = this.Width - this.Padding.Right - comboBoxCustom.Width,
                Y = labelCustom.Bottom - comboBoxCustom.Height
            };
        }

        //overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
        #endregion
    }
}
