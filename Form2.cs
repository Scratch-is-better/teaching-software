using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace real_cool_game
{

    public partial class Form2 : Form
    {

        Label[] labels = new Label[3]; //making array
        Form1 form1 = null; //for linking the forms
        bool won = false; 

        public Form2()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                labels[i] = new Label();
                labels[i].Width = qstnTable.Width;
                labels[i].Height = qstnTable.Height / 3;
                labels[i].AllowDrop = true;
                labels[i].DragEnter += new DragEventHandler(labels_DragEnter);
                labels[i].DragDrop += new DragEventHandler(labels_DragDrop);
                qstnTable.Controls.Add(labels[i]);
            }

           
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e) //universal code for drag and dropping labels
        {
            Label codeBlock = sender as Label; //whatever label was picked will be the sender
            DataObject dragLabel = new DataObject(); //putting the label's data in to a new data object
            dragLabel.SetData(DataFormats.Text, true, codeBlock.Text); 
            DoDragDrop(dragLabel, DragDropEffects.Copy);

        }

        private void labels_DragDrop(object sender, DragEventArgs e)
        {
            Label label = sender as Label;

            label.Tag = (String)e.Data.GetData(DataFormats.Text); //set label text
            label.Text = (String)e.Data.GetData(DataFormats.Text); //set text in table
            //e has data 
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }




        private void Form2_Load(object sender, EventArgs e)
        {

            if (won == true)
            {
                win.Visible = true;
                win.BringToFront();
            }
            else
            {
                win.Visible = false;
            }

            bar.Maximum = 3;
            bar.Step = 1;

            form1 = (Form1)Owner;
            bar.Value = form1.menuBar.Value;

            win.Location = new Point(136, 217);
            qstnTable.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();

            if (bar.Value == 0)
            {
                qstn.Text = "Question 1, loops: How many times will this 'for loop' run?\n for(int i = 0; i < 17440; i++)";
            }

            else if (bar.Value == 1)
            {
                qstn.Text = "Question 2, functions: What's the name of this function?\n\nvoid ReallyCoolAndAwesomeCode()\n{\nint notThis = 0;\n}";

            }

            else if (bar.Value == 2)
            {
                answerBox.Clear();
                answerBox.Hide();
                qstnTable.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                qstn.Text = "Question 3, Order:\nRearrange this code so that it works";

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (answerBox.Text == "17440" && qstn.Text == "Question 1, loops: How many times will this 'for loop' run?\n for(int i = 0; i < 17440; i++)")
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
                qstn.Text = "Question 3, Order:\nRearrange this code so that it works";
            }

            else if (labels[0].Text == label1.Text && labels[1].Text == label2.Text && labels[2].Text == label3.Text)
            {
                bar.PerformStep();
                won = true;
                qstn.Text = "Would you like to play again?";
                win.BringToFront();
                win.Show();
                slide.Show();
                yesNo.Show();
                   
            }



            else
            {
              //  Label4
            }
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            form1.menuBar.Value = bar.Value;

            this.Owner.Show();
            this.Hide();
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



        private void labels_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
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


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void slide_Scroll(object sender, EventArgs e)
        {
            if (slide.Value == 1)
            {
                bar.Value = 0;
            }
        }
    }
}
