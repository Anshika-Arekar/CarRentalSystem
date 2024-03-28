using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarBookingSystem
{
    public partial class Form2 : Form
    {
        // Login Page
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Pass = textBox2.Text;
            String cPass = textBox3.Text;

            if (Pass == cPass)
            {
               
            }
            else
            {
                label5.Text = "Incorrect Password";
            }
            if (!string.IsNullOrEmpty(textBox1.Text) &&
               !string.IsNullOrEmpty(textBox2.Text) &&
               !string.IsNullOrEmpty(textBox3.Text) &&
               Pass == cPass)
            {
                
                Form3 f3 = new Form3();
                this.Visible = false;
                f3.Show();
            }
            else
            {
                MessageBox.Show("Oops Something went wrong :/");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            this.Visible = false;
            f4.Show();
        }
    }
}
