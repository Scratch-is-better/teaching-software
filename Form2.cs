using System;
using System.Drawing;
using System.Windows.Forms;

namespace real_cool_game
{

    public partial class Form2 : Form
    {


        // public static string barValue = kool;


        Label[] labels = new Label[3];

        public Form2()
        {



            InitializeComponent();

            bar.Maximum = 5;
            bar.Step = 1;
            int kool = bar.Value;


            for (int i = 0; i < 3; i++)
            {
                labels[i] = new Label();
                labels[i].AllowDrop = true;
                //   labels[i].DragEnter += new DragEventHandler(labels_DragEnter);
                //   labels[i].DragDrop += new DragEventHandler(labels_DragDrop);
                qstnTable.Controls.Add(labels[i]);

            }




        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }




        private void Form2_Load(object sender, EventArgs e)
        {
            win.Location = new Point(136, 217);
            qstnTable.Hide();
            trackBar1.Visible = false;
            label1.Hide();
            label2.Hide();
            label3.Hide();


            qstn.Text = "Question 1, loops: How many times will this 'for loop' run?\n for(i = 0; i < 17440; i++)";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (bar.Value == 4)
            {
                win.Visible = true;
            }
            else
            {
                win.Visible = false;
            }




            if (answerBox.Text == "17440" && qstn.Text == "Question 1, loops: How many times will this 'for loop' run?\n for(i = 0; i < 17440; i++)")
            {
                bar.PerformStep();
                answerBox.Clear();
                qstn.Text = "Question 2, functions: What's the name of this function?\n\nvoid ReallyCoolAndAwesomeCode()\n{\nint notThis = 0;\n}";
            }

            else if (answerBox.Text == "ReallyCoolAndAwesomeCode" && qstn.Text == "Question 2, functions: What's the name of this function?\n\nvoid ReallyCoolAndAwesomeCode()\n{\nint notThis = 0;\n}")
            {
                bar.PerformStep();
                answerBox.Clear();
                answerBox.Hide();
                qstnTable.Show();
                label1.Show();
                label2.Show();
                label3.Show();
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
