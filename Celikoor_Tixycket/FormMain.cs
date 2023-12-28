using Celikoor_LIB;
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
            SetupPictureBoxEvents();
        }
        FormUtama1 formUtama;
        List<Film> listFilms;
        int minIndex = 1;
        int maxIndex = 10; //listFilm.Count();
        int leftIndex = 1; //absolut
        int rightIndex = 5; //absolut
        bool rightDirection = true;
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void CreatePictureBox()
        {
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            
            PictureBox newPictureBox = new PictureBox();

            if (rightDirection) //left - geser ke kanan
            {
                newPictureBox.Location = new System.Drawing.Point(-93, 120);
                newPictureBox.Name = "pictureBoxPosterLeft2";
                leftIndex--;
                rightIndex--;
                if (leftIndex < minIndex)
                {
                    leftIndex = maxIndex;
                }
                if (rightIndex < minIndex)
                {
                    rightIndex = maxIndex;
                }
                dir += $"Resources\\poster{leftIndex}.jpg";
            }
            else
            {
                newPictureBox.Location = new System.Drawing.Point(1024, 120);
                newPictureBox.Name = "pictureBoxPosterRight2";
                leftIndex++;
                rightIndex++;
                if (leftIndex > maxIndex)
                {
                    leftIndex = minIndex;
                }
                if (rightIndex > maxIndex)
                {
                    rightIndex = minIndex;
                }
                dir += $"Resources\\poster{rightIndex}.jpg";
            }
            
            if (System.IO.File.Exists(dir))
            {
                newPictureBox.BackgroundImage = Image.FromFile(dir);
            }
            newPictureBox.Size = new System.Drawing.Size(192, 232);
           
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
                            buttonLeft.Enabled = true;
                            buttonRight.Enabled = true;
                            CreatePictureBox();
                            SetupPictureBoxEvents();
                            timerSM.Stop();
                        }
                    }
                }
                else
                {
                    if (pictureBox.Name == "pictureBoxPosterRight2")
                    {

                        if (pictureBox.Width < 224 && pictureBox.Height < 302)
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
                            buttonLeft.Enabled = true;
                            buttonRight.Enabled = true;
                            CreatePictureBox();
                            SetupPictureBoxEvents();
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
        private void buttonRight_Click(object sender, EventArgs e)
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
            buttonRight.Enabled = false;
            buttonLeft.Enabled = false;
        }

        private async void buttonLeft_Click(object sender, EventArgs e)
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
            buttonRight.Enabled = false;
            buttonLeft.Enabled = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama1)this.Owner;
            //listFilms = Film.BacaData();
            //maxIndex = listFilms.Count;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            formUtama.LoginSetUp(sender, e);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            formUtama.OpenForm(new FormRegisterKonsumen());
        }

        private void pictureBoxPosterMiddle_Click(object sender, EventArgs e)
        {
            labelFilmName.Text = "berubah";
        }
        private void SetupPictureBoxEvents()
        {
            foreach (PictureBox pictureBox in panelPoster.Controls)
            {
                if(pictureBox.Name == "pictureBoxPosterMiddle")
                {
                    pictureBox.Click += PictureBox_Click;
                    pictureBox.MouseEnter += PictureBox_MouseEnter;
                    pictureBox.MouseLeave += PictureBox_MouseLeave;
                }
                if(pictureBox.Name == "pictureBoxPosterLeft1" || pictureBox.Name == "pictureBoxPosterRight1")
                {
                    pictureBox.Click -= PictureBox_Click;
                    pictureBox.MouseEnter -= PictureBox_MouseEnter;
                    pictureBox.MouseLeave -= PictureBox_MouseLeave;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                string pictureBoxName = clickedPictureBox.Name;
                MessageBox.Show($"Clicked on PictureBox with Name: {pictureBoxName}");
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox enteredPictureBox)
            {
                string pictureBoxName = enteredPictureBox.Name;
                // Add your hover effect or logic here
                enteredPictureBox.BorderStyle = BorderStyle.FixedSingle;
                enteredPictureBox.BackColor = Color.FromArgb(125, Color.Black);
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox leftPictureBox)
            {
                // Reset the hover effect or logic here
                leftPictureBox.BorderStyle = BorderStyle.None;
            }
        }
    }
}
