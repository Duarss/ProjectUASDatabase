using Celikoor_Tixycket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        List<Image> imageList = new List<Image> { Resources.poster1, Resources.poster2, Resources.poster3, Resources.poster4, Resources.poster5};
        int index = 2; //mengikuti poster yang di main page
        bool rightDirection = true;
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void CreatePictureBox()
        {
            PictureBox newPictureBox = new PictureBox();
            if (rightDirection)
            {
                newPictureBox.Location = new System.Drawing.Point(-93, 120);
                newPictureBox.Name = "pictureBoxPosterLeft2";
                index--;
                if(index < 1)
                {
                    index = 5;
                }
            }
            else
            {
                newPictureBox.Location = new System.Drawing.Point(1024, 120);
                newPictureBox.Name = "pictureBoxPosterRight2";
                index++;
                if(index > 5)
                {
                    index = 1;
                }
            }
            newPictureBox.Size = new System.Drawing.Size(192, 232);
            switch (index)
            {
                case 1:
                    newPictureBox.BackgroundImage = Resources.poster1;
                    break;
                case 2:
                    newPictureBox.BackgroundImage = Resources.poster2;
                    break;
                case 3:
                    newPictureBox.BackgroundImage = Resources.poster3;
                    break;
                case 4:
                    newPictureBox.BackgroundImage = Resources.poster4;
                    break;
                case 5:
                    newPictureBox.BackgroundImage = Resources.poster5;
                    break;
            }
            newPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            panelPoster.Controls.Add(newPictureBox);
            
        }
        private void timerSM_Tick(object sender, EventArgs e)
        {
            // untuk dari size kecil ke medium
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (rightDirection)
                {
                    if (pictureBox.Name == "pictureBoxPosterLeft2")
                    {
                        
                        if (pictureBox.Width < 224 && pictureBox.Height < 302)
                        {
                            pictureBox.Width = 224;
                            pictureBox.Height = 302;
                        }
                        if (pictureBox.Left < 142)
                        {
                            pictureBox.Left += 12;
                        }
                        if (pictureBox.Top > 82)
                        {
                            pictureBox.Top -= 8;
                        }
                        if (pictureBox.Left >= 142 && pictureBox.Top <= 82)
                        {
                            pictureBox.Name = "pictureBoxPosterLeft1";
                            buttonRight.Enabled = true;
                            buttonLeft.Enabled = true;
                            CreatePictureBox();
                            label2.Text = index.ToString();
                            timerSM.Stop();
                        }
                    }
                }
                else
                {
                    if (pictureBox.Name == "pictureBoxPosterRight2")
                    {
                        
                        if (pictureBox.Width < 224 &&  pictureBox.Height < 302)
                        {
                            pictureBox.Width = 224;
                            pictureBox.Height = 302;
                        }
                        if (pictureBox.Left > 764)
                        {
                            pictureBox.Left -= 12;
                        }
                        if (pictureBox.Top > 82)
                        {
                            pictureBox.Top -= 8;
                        }
                        if (pictureBox.Left <= 764 && pictureBox.Top <= 82)
                        {
                            pictureBox.Name = "pictureBoxPosterRight1";
                            buttonRight.Enabled = true;
                            buttonLeft.Enabled = true;
                            CreatePictureBox();
                            label2.Text = index.ToString();
                            timerSM.Stop();
                        }
                    }
                }

            }
        }
        private void timerMB_Tick(object sender, EventArgs e)
        {
            // untuk dari size medium ke besar (312, 406) 412, 24
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (rightDirection)
                {
                    if (pictureBox.Name == "pictureBoxPosterLeft1")
                    {
                        if (pictureBox.Width < 312 && pictureBox.Height < 406)
                        {
                            pictureBox.Width = 312;
                            pictureBox.Height = 406;
                        }
                        if (pictureBox.Left < 412)
                        {
                            pictureBox.Left += 16;
                        }
                        if (pictureBox.Top > 24)
                        {
                            pictureBox.Top -= 8;
                        }
                        if (pictureBox.Left >= 412 && pictureBox.Top <= 24)
                        {
                            pictureBox.Name = "pictureBoxPosterMiddle";
                            timerMB.Stop();
                        }
                    }
                }
                else
                {
                    if (pictureBox.Name == "pictureBoxPosterRight1")
                    {
                        if (pictureBox.Width < 312 && pictureBox.Height < 406)
                        {
                            pictureBox.Width = 312;
                            pictureBox.Height = 406;
                        }
                        if (pictureBox.Left > 412)
                        {
                            pictureBox.Left -= 16;
                        }
                        if (pictureBox.Top > 24)
                        {
                            pictureBox.Top -= 8;
                        }
                        if (pictureBox.Left <= 412 && pictureBox.Top <= 24)
                        {
                            pictureBox.Name = "pictureBoxPosterMiddle";
                            timerMB.Stop();
                        }
                    }
                }
            }
        }
        private void timerBM_Tick(object sender, EventArgs e)
        {
            // untuk dari besar ke medium
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (rightDirection)
                {
                    if (pictureBox.Name == "pictureBoxPosterMiddle")
                    {
                        if (pictureBox.Width > 224 && pictureBox.Height > 302)
                        {
                            pictureBox.Width = 224;
                            pictureBox.Height = 302;
                        }
                        if (pictureBox.Left < 764)
                        {
                            pictureBox.Left += 32;
                        }
                        if (pictureBox.Top < 82)
                        {
                            pictureBox.Top += 8;
                        }
                        if (pictureBox.Left >= 764 && pictureBox.Top >= 82)
                        {
                            pictureBox.Name = "pictureBoxPosterRight1";
                            timerBM.Stop();
                        }
                    }
                }
                else
                {
                    if (pictureBox.Name == "pictureBoxPosterMiddle")
                    {
                        if (pictureBox.Width > 224 && pictureBox.Height > 302)
                        {
                            pictureBox.Width = 224;
                            pictureBox.Height = 302;
                        }
                        if (pictureBox.Left > 142)
                        {
                            pictureBox.Left -= 32;
                        }
                        if (pictureBox.Top < 82)
                        {
                            pictureBox.Top += 8;
                        }
                        if (pictureBox.Left <= 142 && pictureBox.Top >= 82)
                        {
                            pictureBox.Name = "pictureBoxPosterLeft1";
                            timerBM.Stop();
                        }
                    }
                }
                
            }
        }

        private void timerMS_Tick(object sender, EventArgs e)
        {
            // untuk dari medium ke kecil (183, 232)  1025, 120
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (rightDirection)
                {
                    if (pictureBox.Name == "pictureBoxPosterRight1")
                    {
                        if (pictureBox.Width > 183 && pictureBox.Height > 232)
                        {
                            pictureBox.Width = 183;
                            pictureBox.Height = 232;
                        }
                        if (pictureBox.Left < 1024)
                        {
                            pictureBox.Left += 48;
                        }
                        if (pictureBox.Top < 120)
                        {
                            pictureBox.Top += 8;
                        }
                        if (pictureBox.Left >= 1024 && pictureBox.Top >= 120)
                        {
                            pictureBox.Name = "pictureBoxPosterRight2";
                            timerMS.Stop();
                        }
                    }
                }
                else
                {
                    if (pictureBox.Name == "pictureBoxPosterLeft1")
                    {
                        if (pictureBox.Width > 183 && pictureBox.Height > 232)
                        {
                            pictureBox.Width = 183;
                            pictureBox.Height = 232;
                        }
                        if (pictureBox.Left > -92)
                        {
                            pictureBox.Left -= 48;
                        }
                        if (pictureBox.Top < 120)
                        {
                            pictureBox.Top += 8;
                        }
                        if (pictureBox.Left <= -92 && pictureBox.Top >= 120)
                        {
                            pictureBox.Name = "pictureBoxPosterLeft2";
                            timerMS.Stop();
                        }
                    }
                }
            }
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            rightDirection = false;
            timerBM.Start();
            timerSM.Start();
            timerMB.Start();
            timerMS.Start();
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (pictureBox.Name == "pictureBoxPosterLeft2")
                {
                    pictureBox.Dispose();
                }
            }
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
        }

        private async void buttonRight_Click(object sender, EventArgs e)
        {
            rightDirection = true;
            timerBM.Start();
            timerSM.Start();
            timerMB.Start();
            timerMS.Start();
            foreach (PictureBox pictureBox in panelPoster.Controls.OfType<PictureBox>())
            {
                if (pictureBox.Name == "pictureBoxPosterRight2")
                {
                    pictureBox.Dispose();
                }
            }
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            dir += "Resources\\poster4.jpg";
            if (System.IO.File.Exists(dir))
            {
                pictureBoxPosterMiddle.BackgroundImage = Image.FromFile(dir);
            }
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {

        }
    }
}
