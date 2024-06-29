using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameHungTrung
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight;
        int speed = 8;
        int score = 0;
        int missed = 0;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Diem.Text = "Saved: " + score;
            Rot.Text = "Missed: " + missed;

            if (goLeft == true && nguoichoi.Left > 0)
            {
                nguoichoi.Left -= 12;
                nguoichoi.Image = Properties.Resources.chicken_normal2;
            }
            if (goRight == true && nguoichoi.Left + nguoichoi.Width < this.ClientSize.Width)
            {
                nguoichoi.Left += 12;
                nguoichoi.Image = Properties.Resources.chicken_normal;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "eggs")
                {

                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {

                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        nguoichoi.Image =Properties.Resources.chicken_hurt;

                    }


                    if (nguoichoi.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                    }
                }
            }

            if (score > 10)
            {
                speed = 9;
            }
            if (score > 20)
            {
                speed = 10;
            }
            if (score > 30)
            {
                speed = 12;
            }
            if (missed > 10)
            {
                Gametimer.Stop();
                MessageBox.Show("Thua rồi!" + Environment.NewLine + "Hãy luyện thêm bạn nhé <3!" + Environment.NewLine + "Click ok to retry");
                RestartGame();
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
            private void RestartGame()
            {

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "eggs")
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                    }
                    nguoichoi.Left = this.ClientSize.Width / 2;
                    nguoichoi.Image = Properties.Resources.chicken_normal;

                    score = 0;
                    missed = 0;
                    speed = 8;

                    goLeft = false;
                    goRight = false;

                    Gametimer.Start();
                }
            }
    } 
}
