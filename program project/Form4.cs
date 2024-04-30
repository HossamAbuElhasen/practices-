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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // لما تضغط على الزرار ينفذ العمليه الحسابيه
            textBox3.Text = "";
            int x, y, sum;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            sum = x + y;
            textBox3.Text += (sum).ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int x, y, sum;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            sum = x * y;
            textBox3.Text += (sum).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int x, y, sum;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            sum = x - y;
            textBox3.Text += (sum).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            float x, y,sum;
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            sum = x / y;
            textBox3.Text += (sum).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

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

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "") 
            {
                textBox4.Text += 1;

            }else

                textBox6.Text += 1;


        }

        private void button19_Click(object sender, EventArgs e)
        {
            float x,y,sum;
            x = float.Parse(textBox4.Text);
            y = float.Parse(textBox6.Text);



            if (textBox5.Text == "+")
            {
                sum = x + y;
                textBox7.Text += sum;
            }
            else if (textBox5.Text == "-")
            {
                sum = x - y;
                textBox7.Text += sum;
            }
            else if (textBox5.Text == "*")
            {
                sum = x * y;
                textBox7.Text += sum;
            }
            else if (textBox5.Text == "/")
            {
                sum = x / y;
                textBox7.Text += sum;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += "2";

            }
            else

                textBox6.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 3;

            }
            else

                textBox6.Text += 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 4;

            }
            else

                textBox6.Text += 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 5;

            }
            else

                textBox6.Text += 5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 6;

            }
            else

                textBox6.Text += 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 7;

            }
            else

                textBox6.Text += 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 8;

            }
            else

                textBox6.Text += 8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text += 9;

            }
            else

                textBox6.Text += 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";



        }
    }
}
