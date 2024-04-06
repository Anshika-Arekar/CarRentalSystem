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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void payUPI_Click(object sender, EventArgs e)
        {
            UPIPage p1 = new UPIPage();
            this.Visible = false;
            p1.Show();
        }

        private void payNetBank_Click(object sender, EventArgs e)
        {
            NetbankingPage p2 = new NetbankingPage();
            this.Visible = false;
            p2.Show();
        }

        private void payCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment will be done at the spot.");
            MessageBox.Show("Hope you enjoy the ride!");
        }
    }
}
