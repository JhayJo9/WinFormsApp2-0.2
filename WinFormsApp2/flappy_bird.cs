using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class flappy_bird : Form
    {
        int gravity = 15;
        int pipe_speed = 8;
        int score = 0;
        public flappy_bird()
        {
            InitializeComponent();
        }

        private void gametimeevent(object sender, EventArgs e)
        {
            bird_ko.Top += gravity;
            pipe_bottom.Left -= pipe_speed;
            pipetop.Left -= pipe_speed;
            score_txt.Text = "Score: " + score;
            if (pipe_bottom.Left < -150)
            {
                pipe_bottom.Left = 705;
                score++;
            }
            if (pipetop.Left < -80)
            {
                pipetop.Left = 705;
                score++;
            }
            if (bird_ko.Bounds.IntersectsWith(pipe_bottom.Bounds) ||
                    bird_ko.Bounds.IntersectsWith(pipetop.Bounds) ||
                    bird_ko.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                ENDgAME();
            }
            if (score > 5)
            {
                pipe_speed = 15;
            }
            if (bird_ko.Top < -25)
            {
                ENDgAME();
            }
        }

        private void bird_ko_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 15;
            }
        }
        private void ENDgAME()
        {
            gametimer.Stop();
            score_txt.Text += " Game Over";
            button1.Show();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit? ");
            Form frm3 = new Main_menu();
            frm3.Show();
        }
    }
}
