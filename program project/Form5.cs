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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
               // ده كود شريط التحميل
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Step = 100;
                progressBar1.PerformStep();
                      
           // لما يضغط على الزر يغير اسم الصفحه
            this.Text = "Title has been changed...";
        }
        private void button2_Click(object sender, EventArgs e)
        {

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Step = 100;
            progressBar2.PerformStep();

            // لتغير خلفيه الصفحه للون الاحمر
             this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            progressBar3.Step = 100;
            progressBar3.PerformStep();

            this.BackColor = Color.Yellow;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 100;
            progressBar4.Step = 100;
            progressBar4.PerformStep();

            this.BackColor = Color.Green;

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

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            progressBar5.Minimum = 0;
            progressBar5.Maximum = 100;
            progressBar5.Step = 100;
            progressBar5.PerformStep();

            // openFileDialog لو عايز اختار صوره خلفيه من الجهاز باستخدام 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                string imgPath = openFileDialog1.FileName;
                this.BackgroundImage = Image.FromFile(imgPath);
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {  // change bg color
            // colorDialog لتغير لون الخلفيه للون اللى نحبه باستخدام
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {   // change img
            // pictureBox1 تغير صوره الاطار ال
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgPath = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = Image.FromFile(imgPath);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        { //fontDialog1 تغير الفونت الخاص باكلام زي النص واللون باستخدام
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                button1.Font = fontDialog1.Font;

                button2.ForeColor = fontDialog1.Color;  
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
                button1.Font = fontDialog1.Font;
                button2.ForeColor = fontDialog1.Color;
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            
        }
    }
}
