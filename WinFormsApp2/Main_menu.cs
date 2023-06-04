using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to Guessing Game");
            Form frm2 = new Guessing_Game();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to flappy bird!!");
            Form formf = new flappy_bird();
            formf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Thank you for using our project!!!");
            Application.Exit();
        }
    }
}
