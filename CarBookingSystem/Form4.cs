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
    public partial class Form4 : Form
    {
        // register page
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*String Name = textBox1.Text;
            String email = textBox2.Text;
            String UserName = textBox3.Text;
            String Pass = textBox4.Text;*/

            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) )
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
    }
}
