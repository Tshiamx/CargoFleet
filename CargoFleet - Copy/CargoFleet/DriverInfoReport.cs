using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace CargoFleet
{
    public partial class DriverInfoReport : Form
    {
        public DriverInfoReport()
        {
            InitializeComponent();
        }

        private string connString = ConfigurationManager.ConnectionStrings["CargoFleet"].ConnectionString;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchLocation().Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Show();
        }

        private void DriverInfoReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDriverInfo();
        }

        private DataTable GetDriverInfo()
        {
            DataTable dtDriverInfo = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["CargoFleet"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from DriverInfo", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtDriverInfo.Load(reader);
                }
            }

                return dtDriverInfo;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand objcmd = new SqlCommand("Select * from DriverInfo where Name like '" + txtSearch.Text + "%'", conn);
            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
