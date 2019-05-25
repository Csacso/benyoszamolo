using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //asdsadasdasd
            double költség;
            if (radioButton1.Checked) költség = Convert.ToDouble(textBox14.Text);
            else if (radioButton2.Checked) költség = Convert.ToDouble(textBox13.Text);
            else
            {
                MessageBox.Show("Kérem jelölje ki hogy benzinnel, vagy diesellel megy az autója köszi heló");
                return;
            }
            double megtettút = Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox2.Text);
            double kedvesautó = Convert.ToDouble(textBox12.Text) / 100;

            double hahahihi = kedvesautó * megtettút * költség;
            textBox1.Text = hahahihi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
