using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarBookingSystem
{
    public partial class Form2 : Form
    {
        // Login Page
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\areka\OneDrive\Documents\miniProDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False; TrustServerCertificate=true");

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
            String Pass = password.Text;
            String cPass = textBox3.Text;

            if (Pass == cPass)
            {
                
            }
            else
            {
                label5.Text = "Passwords do not match.";
            }
            if (!string.IsNullOrEmpty(username.Text) &&
               !string.IsNullOrEmpty(password.Text) &&
               !string.IsNullOrEmpty(textBox3.Text) &&
               Pass == cPass)
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                
                cmd.CommandText = "SELECT password FROM dbpro where username = '" + username.Text +"';";
                //cmd.Parameters.AddWithValue("@id", insertedRowId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string retrievedPassword = reader.GetString(0); // Assuming username is stored as string
                        if (retrievedPassword == password.Text)
                        {
                            Form3 f3 = new Form3();
                            this.Visible = false;
                            f3.Show();
                            con.Close();
                        }
                        else MessageBox.Show("aaaaaa");
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please Register :)");
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Oops Something went wrong :/");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            this.Visible = false;
            f4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
