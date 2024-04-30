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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
          //  timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("welcome for my project","weclome page", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Stop();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioDark_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.BackColor = Color.MediumTurquoise;
            }
            else
            {
                this.BackColor = Color.DimGray;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.MaxLength = 8;
            txtPass.PasswordChar = '*';
            txtPass.CharacterCasing = CharacterCasing.Lower;
            txtPass.TextAlign = HorizontalAlignment.Center;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            /*

            string x, y;
            x = textBox1.Text;
            y = txtPass.Text;
           
            if (textBox1.Text == "admin" && txtPass.Text == "12345")
            {

                MessageBox.Show("thank you for countiune \n" + $"your name is :{x}\n" + $"your password is :{y}");
            
               
            }
            else
            {
                MessageBox.Show("wrong your name or password Not correct");
            }
            */
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();

            f10.ShowDialog();
            this.Close();
        }
    }
}
