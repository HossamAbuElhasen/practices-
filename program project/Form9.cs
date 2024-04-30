using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_project
{
    public partial class Form9 : Form
    {
        int Tasks = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tasks = int.Parse(textBox1.Text);
            if (Tasks == 1)
            {
                groupBox1.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = true;
            }
            else if (Tasks == 2)
            {
                groupBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button1.Enabled = true;
            }
            else if (Tasks == 3)
            {
                groupBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                button1.Enabled = true;
            }
            else if (Tasks == 4)
            {
                groupBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                button1.Enabled = true;
            }
            else if (Tasks == 5)
            {
                groupBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show(Tasks + " is Out of the range", "Sorry !!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000*20;
            timer1.Start();

            if (Tasks == 1)
            {
                checkBox1.Visible = true;
                checkBox1.Text = textBox2.Text;
            }
            else if (Tasks == 2)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox1.Text = textBox2.Text;
                checkBox2.Text = textBox3.Text;
            }
            else if (Tasks == 3)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox1.Text = textBox2.Text;
                checkBox2.Text = textBox3.Text;
                checkBox3.Text = textBox4.Text;
            }
            else if (Tasks == 4)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox1.Text = textBox2.Text;
                checkBox2.Text = textBox3.Text;
                checkBox3.Text = textBox4.Text;
                checkBox4.Text = textBox5.Text;
            }
            else if (Tasks == 5)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox1.Text = textBox2.Text;
                checkBox2.Text = textBox3.Text;
                checkBox3.Text = textBox4.Text;
                checkBox4.Text = textBox5.Text;
                checkBox5.Text = textBox6.Text;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;

            textBox1.Text =
            textBox2.Text =
            textBox3.Text =
            textBox4.Text =
            textBox5.Text =
            textBox6.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Forget:\n" +
                checkBox1.Text + "\n"+
                checkBox2.Text + "\n" +
                checkBox3.Text + "\n" + 
                checkBox4.Text + "\n" +
                checkBox5.Text + "\n");
        }
    }
}