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

namespace CarBookingSystem
{
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\areka\OneDrive\Documents\miniProDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False; TrustServerCertificate=true");

        private void details_Load(object sender, EventArgs e)
        {
            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select username,password,carRented,isPaid from dbpro ", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            grid.DataSource = dt;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14, FontStyle.Bold);
        }
    }
}
