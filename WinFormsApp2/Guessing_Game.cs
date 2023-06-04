using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Guessing_Game : Form
    {
        Random random = new Random();
        int number;
        int guesses = 0;
     
        int i;
        public Guessing_Game()
        {
            InitializeComponent();
            loadQuestion();
        }
        private void loadQuestion()
        {
            number = random.Next(1, 100);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit? ");
            Form frm3 = new Main_menu();
            frm3.Show();
        }

        private void Guessing_Game_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEnterNumber.Text == "")
            {
                MessageBox.Show("Please enter your guesses number ");
            }
            else
            {
                i = int.Parse(txtEnterNumber.Text);
                guesses += 1;
                lblGuessed.Text = ("You guessed " + guesses + " times");
            }
            
            if (i == number)
            {
                 MessageBox.Show("You got it right");
            }
            else if (i > number)
            {
                MessageBox.Show("go lower");
               // txtEnterNumber.Text = "";
            }
            else
            {
                
               MessageBox.Show("go higher");
               // txtEnterNumber.Text = "";
            }
        }
    }
}
