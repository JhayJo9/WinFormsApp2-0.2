using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to out?");

            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "ITEC21" && txt_pass.Text == "12345")
            {
                this.Hide();

                MessageBox.Show("Welcome to ITEC21");
                Form frm1 = new Main_menu();
                frm1.Show();
            }
            else if (txt_user.Text == "" && txt_pass.Text == "12345")
            {
                MessageBox.Show("Please enter your User ID");
            }
            else if (txt_user.Text == "ITEC21" && txt_pass.Text == "")
            {
                MessageBox.Show("Please enter your Password");
            }
            else if (txt_user.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("Please fill up your Information");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

       
    }
}
