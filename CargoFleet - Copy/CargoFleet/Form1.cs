using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFleet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            new OfficeMLogIn().Show();
            
        }

        private void btnVehicleInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VehicleInfoLogIn().Show();
        }

        private void btnTripManager_Click(object sender, EventArgs e)
        {

            this.Hide();
            new TripMLogIn().Show();

        }

        private void btnServiceManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ServiceMLogIn().Show();

            
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TimesheetMLogIn().Show();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DriverLogIn().Show();
        }
    }
}
