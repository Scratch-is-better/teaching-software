using System;
using System.Windows.Forms;

namespace real_cool_game
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
            menuBar.Maximum = 3;
           
            if (menuBar.Value == 2)
            {
                winMenu.Show();
            }
            else
            {
                winMenu.Hide();
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}


