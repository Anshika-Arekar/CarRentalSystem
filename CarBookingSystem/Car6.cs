using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBookingSystem
{
    public partial class Car6 : Form
    {
        public Car6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            this.Visible = false;
            p.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Visible = false;
            f3.Show();
        }
    }
}
