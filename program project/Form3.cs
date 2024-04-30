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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void change_Click(object sender, EventArgs e)
        {
          // تغير العملات من جنيه لى دولار ويورو
            float LE = float.Parse(textBox1.Text);
            textBox2.Text = (LE / 30.82 + " $").ToString();
            textBox3.Text = (LE / 32.50).ToString();
            textBox4.Text = (LE / 8).ToString();

        }
        private void clear_Click(object sender, EventArgs e)
        {
            // زرار حذف مابداخل الخانات
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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
    }
}
