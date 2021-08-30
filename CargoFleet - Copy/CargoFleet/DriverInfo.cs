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
using System.Data.SqlClient;
using System.Configuration;


namespace CargoFleet
{
    public partial class DriverInfo : Form
    {
        public DriverInfo()
        {
            InitializeComponent();
        }

        
        private string connString = ConfigurationManager.ConnectionStrings["CargoFleet"].ConnectionString;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string FName = txtName.Text;
            //string LName = txtSurname.Text;
            //string Years = txtAge.Text;
            //string CarDriven = txtVehicleType.Text;
            //string User = txtSurname.Text;
            //string PassKey = txtPassword.Text;

            //string path = "DriverInformation.txt";
            //StreamWriter writeFile = File.AppendText(path);

            //writeFile.WriteLine("Name" + txtName.Text);
            //writeFile.WriteLine("Surname" + txtSurname.Text);
            //writeFile.WriteLine("Age" + txtAge.Text);
            //writeFile.WriteLine("Vehicle Type" + txtVehicleType.Text);

            //writeFile.WriteLine("______________________________________________");

            //DriverI driverI = new DriverI(FName, LName, Years, CarDriven, User, PassKey);

            //VehicleRepository.Add(driverI, Count);
            //Count += 1;
            //MessageBox.Show($"{FName} has been registered into the database");


            SqlConnection conn = new SqlConnection(connString);


            try
            {
                conn.Open();
                string query = "Insert into DriverLogIn values ( @Username, @userPassword)";
                SqlCommand cmd = new SqlCommand(query, conn);
               
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.ToString());
                cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Username and passsword saved into the database");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

            try
            {
                conn.Open();
                string query = "Insert into DriverInfo values ( @Name, @Surname, @Age, @VehicleDriven)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.ToString());
                cmd.Parameters.AddWithValue("@Age", txtAge.Text.ToString());
                cmd.Parameters.AddWithValue("@VehicleDriven", txtVehicleType.ToString());
                conn.Close();


                MessageBox.Show("Vehicle Information is saved into");
            }
            catch (Exception)
            {
                
                
            }

            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtVehicleType.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Show();
        }
    }
    
}
