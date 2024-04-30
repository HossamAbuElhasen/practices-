using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace program_project
{
    public partial class Form8 : Form
    {
        public Form8()
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

        private void Add_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string salary = txtSalry.Text;
            string emp = id + "_" + name + "_" + salary + "\n";
            File.AppendAllText(@"File2.txt", emp);
            MessageBox.Show("Employee Add successfully");
        }

        private void update_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"File2.txt");
            string id = txtID.Text;
            string name = txtName.Text;
            string salary = txtSalry.Text;
            string emp = id + "_" + name + "_" + salary ;

            lines[listBox1.SelectedIndex] = emp;
            File.WriteAllLines(@"File2.txt",lines);
            MessageBox.Show("update Employee successfully");
            listBox1.Items.Clear();
            string[]content=File.ReadAllLines(@"File2.txt");
            listBox1.Items.AddRange(content);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string []lines=File.ReadAllLines(@"File2.txt");
            string[] newLines = new string[lines.Length - 1];
            int x = 0;

            for(int i = 0; i < lines.Length; i++)
            {
                if (i == listBox1.SelectedIndex)
                {
                    continue;
                }
                newLines[x] = lines[i];
                x++;
            }
            File.WriteAllLines(@"File2.txt",newLines);
            MessageBox.Show(" Employee Deleted successfully");

            listBox1.Items.Clear();
            string[] content = File.ReadAllLines(@"File2.txt");
            listBox1.Items.AddRange(content);

        }

        private void search_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"File2.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Contains(searchID.Text))
                {
                    txtShow.Text += line + "\n";
                }
            }
            if (txtShow.Text == "")
            {
                txtShow.Text = "not found";
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines(@"File2.txt"));

        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtID.Text = "";
            txtName.Text = "";
            txtSalry.Text = "";
            txtShow.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = listBox1.SelectedItem.ToString();

            string[] data = line.Split('_');

            txtID.Text = data[0];
            txtName.Text = data[1];
            txtSalry.Text = data[2];
        }
    }
}
;