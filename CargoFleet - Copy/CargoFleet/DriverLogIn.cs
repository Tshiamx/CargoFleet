using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CargoFleet
{
    public partial class DriverLogIn : Form
    {
        public DriverLogIn()
        {
            InitializeComponent();
        }

        private string connString = ConfigurationManager.ConnectionStrings["CargoFleet"].ConnectionString;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //verifying the data that are to see if it matches with the that is in the database 
            SqlConnection conn = new SqlConnection(connString);

            string query = "Select * from DriverLogIn where Username = '" + txtUsername.Text.Trim() + "'and userPassword ='" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                //proceeding to the next window if the password and username matches with the ones in the database 
                this.Hide();
                new SearchLocation().Show();
            }
            else
            {
                MessageBox.Show("Please check your Username number and Password and make sure they are correct");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Show();
        }
    }
}
