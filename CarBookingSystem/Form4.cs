using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarBookingSystem
{
    public partial class Form4 : Form
    {
        // register page
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\areka\OneDrive\Documents\miniProDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False; TrustServerCertificate=true");
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(username.Text) &&
                !string.IsNullOrEmpty(password.Text))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.CommandText = "INSERT INTO dbpro (username, password) VALUES (@username, @password)";
                    cmd.ExecuteNonQuery();
                    Form3 f3 = new Form3();
                    this.Visible = false;
                    f3.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Oops Something went wrong :/");
                }
                con.Close() ;
            

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
