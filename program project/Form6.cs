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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // المنبه وده معناه اول مايشتغل هينفذ شرط معين
            this.BackColor = Color.DimGray;
        }

        private void button2_ContextMenuStripChanged(object sender, EventArgs e)
        {
           
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button2.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // contextMenuStrip ده عشان لما نضغط كلك يمين على الزرار يظهرلنا اكتر من اوبشن
            // بنملى عناصره من الفورم نفسها
            button2.BackColor = Color.Green;
            // تغير لون الزرار للاخضر
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex == 0)
            {
                this.BackColor = Color.Red;
            }
            else  if (selectedIndex == 1)
            {
                this.BackColor = Color.Green;
            }
            else if (selectedIndex == 2)
            {
                this.BackColor = Color.Blue;
            }
            else if (selectedIndex == 3)
            {
                this.BackColor = Color.MediumTurquoise;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox4.Checked = false;
                timer1.Interval = 2000;
                timer1.Start();
                
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                timer1.Interval = 4000;
                timer1.Start();

            }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 100;
            progressBar1.PerformStep();
            if (checkBox2.Checked == true )
            {
                comboBox2.Items.Add(checkBox2.Text);

            }
            if (checkBox3.Checked == true)
            {
                comboBox2.Items.Add(checkBox3.Text);

            }
            if (checkBox5.Checked == true)
            {
                comboBox2.Items.Add(checkBox5.Text);

            }
            if (checkBox6.Checked == true)
            {
                comboBox2.Items.Add(checkBox6.Text);

            }

            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
            if (selectedIndex == 0)
            {
                richTextBox1.Text += checkBox2.Text + "\n";
            }
            if (selectedIndex == 1)
            {
                richTextBox1.Text += checkBox3.Text + "\n";
            }
            if (selectedIndex == 2)
            {
                richTextBox1.Text += checkBox5.Text + "\n";
            }
            if (selectedIndex == 3)
            {
                richTextBox1.Text += checkBox6.Text + "\n";
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
