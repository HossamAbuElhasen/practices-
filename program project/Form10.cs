using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace program_project
{
    public partial class Form10 : Form
    {
        int scrore = 0;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "choose program..";
            comboBox1.Items.Add("computer secince");
            comboBox1.Items.Add("Mathmetics & cs");
            comboBox1.Items.Add("phcs");
            timer1.Start();
            timer1.Interval = 50000;

          toolTip1.SetToolTip(button1, "click here");

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "this app";
            notifyIcon1.BalloonTipTitle = "welcome";
            notifyIcon1.ShowBalloonTip(6000);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("you should enter your name");

            }
            else
            {
                // qusestion 

                if (checkBox1.Checked == true)
                {
                    scrore += 1;
                }
                else if
                (checkBox2.Checked == true)
                {
                    scrore += 0;
                }

                else if
               (checkBox3.Checked == true)
                {
                    scrore += 0;
                }

                // qusestion 2
                if (checkBox4.Checked == true)
                {
                    scrore += 0;
                }
                else if
                (checkBox5.Checked == true)
                {
                    scrore += 1;
                }

                else if
               (checkBox6.Checked == true)
                {
                    scrore += 0;
                }


                // qusestion 3
                if (checkBox9.Checked == true)
                {
                    scrore += 0;
                }
                else if
                (checkBox8.Checked == true)
                {
                    scrore += 0;
                }

                else if
                (checkBox7.Checked == true)
                {
                    scrore += 1;
                }
                else
                {
                    MessageBox.Show("you should show answer");
                }


                richTextBox1.Text = textBox1.Text + "\n";

                int selectIndex = comboBox1.SelectedIndex;
                if (selectIndex == 0)
                {
                    richTextBox1.Text += ("computer secince \n");
                }
                else if (selectIndex == 1)
                {
                    richTextBox1.Text += ("Mathmetics & cs \n");
                }
                else if (selectIndex == 2)
                {
                    richTextBox1.Text += (" PH & cs \n");

                }
                else
                {
                    MessageBox.Show("you should select program");
                }

                if (radioButton1.Checked == true)
                {
                    richTextBox1.Text += radioButton1.Text + "\n";
                }
                else if (radioButton2.Checked == true)
                {
                    richTextBox1.Text += radioButton2.Text + "\n";
                }
                else if (radioButton3.Checked == true)
                {
                    richTextBox1.Text += radioButton3.Text + "\n";
                }
                else if (radioButton4.Checked == true)
                {
                    richTextBox1.Text += radioButton4.Text + "\n"; 
                }
                else
                {
                    MessageBox.Show("you should selet level");
                }
            }
            richTextBox1.Text += ("your score is "+scrore);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Stop();

            MessageBox.Show("your time is end");
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            richTextBox1.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;


        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // toolTip1_Popup يعنى لما اوقف الموس فى مكان يظهر الرساله
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // trackBar1_Scroll
            MessageBox.Show(trackBar1.Value.ToString());
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // اضافه لينك
            // using System.Diagnostics; شرط اضافه اللينك نكتب
            linkLabel1.LinkVisited = true;
            Process.Start("http://www.facebook.com");
        }
    }
}
