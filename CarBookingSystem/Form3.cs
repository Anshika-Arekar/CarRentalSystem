using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBookingSystem
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (rentedTo != null)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\areka\OneDrive\Documents\miniProDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False; TrustServerCertificate=true");

        // Main UI
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car1 c1 = new Car1();
            this.Visible = false;
            c1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car2 c2 = new Car2();
            this.Visible = false;
            c2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Car3 c3 = new Car3();
            this.Visible = false;
            c3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car4 c4 = new Car4();
            this.Visible = false;
            c4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car5 c5 = new Car5();
            this.Visible = false;
            c5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car6 c6 = new Car6();
            this.Visible = false;
            c6.Show();
        }
    }
}
